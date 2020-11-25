#define _CRT_SECURE_NO_WARNINGS
#include <windows.h> 
#include <tchar.h> 
#include <time.h> 
#include"resource.h"
#include <iostream>

enum TicTac {Cross, Zero};
LRESULT CALLBACK WindowProc(HWND, UINT, WPARAM, LPARAM);
HWND* CreateButtons(HWND hParent);
HWND* ChangeButtons(HWND hParent, int id, TicTac Who);
HWND* DeleteButtons(HWND hParent);
HWND hwind[15];
int moves[9] = {5,5,5,5,5,5,5,5,5};
int counter = 0;
bool flag = false;
int move = 0;
INT WINAPI WinMain(HINSTANCE hInst, HINSTANCE hPrevInst, LPSTR lpszCmdLine, int nCmdShow)
{
	/*srand(time(NULL));*/
	WNDCLASSEX wcl;					

	TCHAR szClassWindow[] = TEXT("Cross&&Nulls"); 
	wcl.cbSize = sizeof(WNDCLASSEX);   
	wcl.style = CS_HREDRAW | CS_VREDRAW | CS_DBLCLKS;
	wcl.lpfnWndProc = WindowProc;		
	wcl.cbClsExtra = 0;					
	wcl.cbWndExtra = 0;					
	wcl.hInstance = hInst;				
	wcl.hIcon = LoadIcon(NULL, IDI_APPLICATION);
	wcl.hCursor =LoadCursor(NULL, IDC_ARROW);  						
	wcl.hbrBackground = CreateSolidBrush(RGB(0, 0, 0)); 
	wcl.lpszMenuName = NULL;			
	wcl.lpszClassName = szClassWindow;	
	wcl.hIconSm = NULL;					

	HWND hWnd;							
	MSG msg;

	if (!RegisterClassEx(&wcl))
		return -1;				

	hWnd = CreateWindowEx(0,szClassWindow, TEXT("Cross&&Nulls"),WS_OVERLAPPEDWINDOW,CW_USEDEFAULT,CW_USEDEFAULT,CW_USEDEFAULT,CW_USEDEFAULT,NULL,NULL,hInst,NULL);					
	ShowWindow(hWnd, nCmdShow);
	UpdateWindow(hWnd);

	while (GetMessage(&msg, NULL, 0, 0))
	{
		TranslateMessage(&msg);	
		DispatchMessage(&msg);	
	}

	return 0;
}


LRESULT CALLBACK WindowProc(HWND hWnd, UINT uMessage, WPARAM wParam, LPARAM lParam)
{
	static TCHAR	 str[100];
	static	POINT pDown, pUp;
	static UINT stCounter = 0;

	switch (uMessage)
	{

	case WM_CREATE:
	
		CreateButtons(hWnd);
		break; 
	

	case WM_SHOWWINDOW:
		MessageBox(hWnd, TEXT("The GAME is started"), TEXT("Start GAME"), MB_OK);
		break;

	case WM_CLOSE:
		if (MessageBox(hWnd, TEXT("Do you want to close the window?"), TEXT("Closing"), MB_YESNO) == IDYES)
			SendMessage(hWnd, WM_DESTROY, 0, 0);
		break;

	case WM_COMMAND:

		switch (LOWORD(wParam))
		{
		
		case IDÑ_BUTTON_1:
		case IDÑ_BUTTON_2:
		case IDÑ_BUTTON_3:
		case IDÑ_BUTTON_4:
		case IDÑ_BUTTON_5:
		case IDÑ_BUTTON_6:
		case IDÑ_BUTTON_7:
		case IDÑ_BUTTON_8:
		case IDÑ_BUTTON_9:
				TicTac s;
				s = ++move % 2 == 0 ? Zero : Cross;
				ChangeButtons(hWnd, LOWORD(wParam), s);
			if (counter==9||flag) {
				if (MessageBox(hWnd, TEXT("Do you want to play again?"), TEXT(""), MB_YESNO) == IDYES) {
					for (int i=0; i<9;i++)
						moves[i] = 5;
					DeleteButtons(hWnd);
					CreateButtons(hWnd);
					flag = false;
					counter = 0;
				}
				else {
					SendMessage(hWnd, WM_DESTROY, 0, 0);
				}
			}
			break;
		default:
			break;
		}

		break;


	case WM_DESTROY:		
		PostQuitMessage(0); 
		break;

	default:
		return DefWindowProc(hWnd, uMessage, wParam, lParam);
	}
	return 0;
}


HWND* CreateButtons(HWND hParent)
{
	int x = 150, y = 70, width = 150;
	for (int i = 0; i < 9; i++) {
		if (i == 3 || i == 6) {
			y += width + 10;
			x = 150;
		}
		hwind[i] = CreateWindowEx(WS_EX_TRANSPARENT, TEXT("BUTTON"),
			NULL, WS_BORDER | WS_CHILDWINDOW | WS_VISIBLE | BS_BITMAP | BS_CENTER | BS_PUSHBUTTON,
			x += width+10, y, width, width, hParent, (HMENU)(103 + i), GetModuleHandle(0), 0);
	
	}
	return hwind;
}


HWND* ChangeButtons(HWND hParent, int id, TicTac Who) {
	
	if (moves[id - 103] == 5) {
		moves[id - 103] = (int)Who;
		SendMessage(hwind[id - 103], BM_SETIMAGE, IMAGE_BITMAP, (LPARAM)LoadBitmap(GetModuleHandle(0), MAKEINTRESOURCE(101 + Who)));
		counter++;
	}
	else {
		MessageBox(hParent, TEXT("This field not empty"), TEXT(""), MB_OK);
	}

	if (moves[0]== 0 && moves[1]==0&&moves[2]==0||
		moves[0] == 0 && moves[3] == 0 && moves[6] == 0||
		moves[0] == 0 && moves[4] == 0 && moves[8] == 0||
		moves[2] == 0 && moves[4] == 0 && moves[6] == 0||
		moves[3] == 0 && moves[4] == 0 && moves[5] == 0||
		moves[6] == 0 && moves[7] == 0 && moves[8] == 0||
		moves[1] == 0 && moves[4] == 0 && moves[7] == 0||
		moves[2] == 0 && moves[5] == 0 && moves[8] == 0) {
		MessageBox(hParent, TEXT("Cross is winner"), TEXT(""), MB_OK);
		flag = true;
	}else if (moves[0] == 0 && moves[1] == 0 && moves[2] == 0 ||
		moves[0] == 1 && moves[3] == 1 && moves[6] == 1 ||
		moves[0] == 1 && moves[4] == 1 && moves[8] == 1 ||
		moves[2] == 1 && moves[4] == 1 && moves[6] == 1 ||
		moves[3] == 1 && moves[4] == 1 && moves[5] == 1 ||
		moves[6] == 1 && moves[7] == 1 && moves[8] == 1 ||
		moves[1] == 1 && moves[4] == 1 && moves[7] == 1 ||
		moves[2] == 1 && moves[5] == 1 && moves[8] == 1) {
		MessageBox(hParent, TEXT("Zero is winner"), TEXT(""), MB_OK);
		flag = true;
	}

	return hwind;
}

HWND* DeleteButtons(HWND hParent)
{
	for (int i = 0; i < 9; i++) {
		DestroyWindow(hwind[i]);
	}
	return hwind;
}






