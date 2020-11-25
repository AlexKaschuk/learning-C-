#define _CRT_SECURE_NO_WARNINGS
#include <windows.h> 
#include <tchar.h> 
#include <time.h> 
#include"resource.h"
#include"gradient.h"

//�������� ������� ���������
LRESULT CALLBACK WindowProc(HWND, UINT, WPARAM, LPARAM);




											   //	INT WINAPI WinMain(
											   //	HINSTANCE hInst,		//	���������� ���������� ����������
											   //	HINSTANCE hPrevInst,	//	����� 0 � ��������� ��� �������������
											   //	LPSTR	lpszCmdLine,	//	���������  ��  ������,  �  �������  ����������
											   //							//	��������� ����������, ���� ��� �������� � ������ ��������� ������ 
											   //	int nCmdShow			//	������ ������������ ���� ��� ������� ���������
											   
											   //	int nCmdShow:
											   //	SW_HIDE				�������� ���� � ������������ ������ ����.
											   //	SW_MAXIMIZE			����������� ��������� ���� �� ���� �����.
											   //	SW_MINIMIZE			������������ ��������� ���� � ������������ ��������� ���� �������� ������ Z ������.
											   //	SW_RESTORE			������������ � ���������� ����.���� ���� �������������� ��� ����������, ������� ��������������� ��� � �������� ��������� � ������.���������� ������ ������� ���� ���� ��� �������������� ���������� ����.
											   //	SW_SHOW				���������� ���� � ������� �� ����� ��� � ��� ������� ������� � �������.
											   //	SW_SHOWMAXIMIZED	������������ ���� � ���������� ��� ��� ����������� ����.
											   //	SW_SHOWMINIMIZED	������������ ���� � ���������� ��� ��� ��������� ����.
											   //	SW_SHOWMINNOACTIVE	���������� ���� ��� ��������� ����.��� �������� ���������� SW_SHOWMINIMIZED, �� ����������� ����, ��� ���� �� ��������������.
											   //	SW_SHOWNA			���������� ���� � ��� ������� ������� � �������.��� �������� ���������� SW_SHOW, �� ����������� ����, ��� ���� �� ��������������.
											   //	SW_SHOWNOACTIVATE	���������� ���� � ��� ��������� ������ � ���������.��� �������� ���������� SW_SHOWNORMAL, �� ����������� ����, ��� ���� �� ������������.
											   //	SW_SHOWNORMAL		������������ � ���������� ����.���� ���� �������������� ��� ����������, ������� ��������������� ��� � �������� ��������� � ������.���������� ������ ������� ���� ���� ��� ������ ���� � ������ ���.

//����� �����
INT WINAPI WinMain(HINSTANCE hInst, HINSTANCE hPrevInst, LPSTR lpszCmdLine, int nCmdShow)
{
	srand(time(NULL));
	WNDCLASSEX wcl;					//	��������� WNDCLASSEX �������� ���������� � ������ ����. ��� ������������ � ��������� RegisterClassEx � GetClassInfoEx. 
									//typedef struct
									//{
									//	UINT  cbSize;					//	������������� ������ ���� ���������, � ������. �������������� ���� ���� ��������� � sizeof (WNDCLASSEX). ���������, ��� ���������� ���� ���� ��������� ����� ������� ������� GetClassInfoEx
									//	UINT  style;					//	����� ���� ������������ ����������� ���������� ���������������� ��������. �������� ����� �� �������� ������ ����, ��� �������� ������ �� ����������
									//	WNDPROC  lpfnWndProc;			//	��������� �� ������� ���������.  �� ������ ������������ ������� CallWindowProc, ����� ������� ������� ���������
									//	int  cbClsExtra;				//	���������� ���������� �������������� ���� ������������� ��������� ������.
									//	int  cbWndExtra;				//	���������� ���������� �������������� ���� ������������� ��������� ����.
									//	HINSTANCE  hInstance;			//	���������� ����������, ������� �������� ������� ��������� ��� ������.
									//	HICON  hIcon;					//	���������� ������. ���� ������� ������ ��������� ���������� ������� ������. ���� ���� ������� ����� �������� NULL, ������� ������������� ������ �� ���������.
									//	HCURSOR  hCursor;				//	���������� �������. ���� ������� ������ ��������� ���������� ������� �������. ���� ���� ������� ����� �������� NULL, ���������� ������ ���� ���������� ����� ������� ��� ����������� ���� � ���� ����������.
									//	HBRUSH  hbrBackground;			//	���������� ����� ����. ���� ������� ����� ���� ������������ �����, ������� ����� �������������� ��� ������� ����, ��� ��� ����� ���� �������� �����.
									//	LPCTSTR  lpszMenuName;			//	��������� �� ��� ������� ����. ���� ���� ������� ����� �������� NULL, ���� ����� ������ �� ����� ����.
									//	LPCTSTR  lpszClassName;			//	��������� ��� ������ ��� ���������� ������ ����. ������������ ����� lpszClassName 256.
									//	HICON  hIconSm;					//	���������� ���������� ������, ������� ������ � ������� ����. ���� ���� ���� ��������� - ����� (NULL), ������� ���� ������ ������, ������������ ������ ��������� hIcon ��� ������ ���������������� �������, ����� ������������ ��� ��������� ������.
									//	} WNDCLASSEX, *PWNDCLASSEX;



//1. ����������� ������ ����
	TCHAR szClassWindow[] = TEXT("MainWindow"); /* ��� ������ ���� */
	wcl.cbSize = sizeof(WNDCLASSEX);    // ������ ��������� WNDCLASSEX
	wcl.style = CS_HREDRAW | CS_VREDRAW|CS_DBLCLKS;//������������ �� ����, ���� ������ ������ �� ����������� ��� �� ���������  // CS(Class Style) - ����� ������ ����
	wcl.lpfnWndProc = WindowProc;		// ����� ������� ���������
	wcl.cbClsExtra = 0;					// ������������ Windows
	wcl.cbWndExtra = 0;					// ������������ Windows
	wcl.hInstance = hInst;				// ���������� ������� ����������
										// �������� ����������� ������
	wcl.hIcon =									LoadIcon(NULL, IDI_APPLICATION); 
												//(HICON)LoadIcon(GetModuleHandle(0), MAKEINTRESOURCE(IDI_ICON3));
												//(HICON)LoadImage(NULL, TEXT("my_icon.ico"), IMAGE_ICON, 0, 0, LR_DEFAULTSIZE | LR_LOADFROMFILE);
																						 
											// �������� ������������ ������� 
	wcl.hCursor =							//LoadCursor(NULL, IDC_ARROW);  

											//LoadCursor(GetModuleHandle(0), MAKEINTRESOURCE(IDC_CURSOR1)); 
											LoadCursorFromFile(TEXT("left_ptr.cur"));// ;
	wcl.hbrBackground = CreateSolidBrush(RGB(115, 110, 250)); //(HBRUSH)GetStockObject(DEFAULT_PALETTE);// ���������� ���� ����� ������
	wcl.lpszMenuName = NULL;			//���������� �� �������� ���� 
	wcl.lpszClassName = szClassWindow;	//��� ������ ���� 
	wcl.hIconSm = NULL;					// ���������� ��������� ������

	HWND hWnd;							//���������� ����
	MSG msg;

//2. ����������� ������ ����
	if (!RegisterClassEx(&wcl))
		return -1;				// ��� ��������� ����������� - �����
	
//3. �������� ���� 

	hWnd = CreateWindowEx(		// ��������� ���� � ���������� hWnd ������������� ���������� ���� 
		0,						// ����������� ����� ����
		szClassWindow,			// ��� ������ ����
		TEXT("INTRODUCTION TO WINAPI"),	// ��������� ����
		WS_OVERLAPPEDWINDOW,	// ����� ���� ( ���������, �����, ����������� ������ �������, ��������� ����, ������ ������������ � ���������� ���� )
		CW_USEDEFAULT,			// �-���������� ������ �������� ���� ����
		CW_USEDEFAULT,			// y-���������� ������ �������� ���� ����
		CW_USEDEFAULT,			// ������ ����
		CW_USEDEFAULT,			// ������ ����
		NULL,					//GetDesktopWindow()  ���������� ������������� ����
		NULL,					// ���������� ���� ���� (ID ����)
		hInst,					// ������������� ����������, ���������� ����
		NULL);					// ��������� �� ������� ������ ����������


//4. ����������� ����
	ShowWindow(hWnd, nCmdShow);
//5. ����������� ����
	UpdateWindow(hWnd);



//6. ������ ����� ��������� ���������			
	while (GetMessage(&msg,NULL, 0, 0))// ��������� ���������� ��������� �� ������� ��������� 
	{
		TranslateMessage(&msg);	// ���������� ���������
		DispatchMessage(&msg);	// ��������������� ���������
	}

//6. ����� �� WinMain
	return 0;
}




//������� ���������
LRESULT CALLBACK WindowProc(HWND hWnd, UINT uMessage, WPARAM wParam, LPARAM lParam)
{
	static TCHAR	 str[100];
	static	POINT pDown, pUp;
	static UINT stCounter = 0;
	switch (uMessage)
	{

		case WM_CREATE:
			//MessageBox(hWnd, TEXT("Created"), TEXT("Info"), MB_OK);
			if ((GetClassLong(hWnd, GCL_STYLE)&CS_DBLCLKS) == 0)
			{
				//MessageBox(hWnd, TEXT("Ignore double clicks"), TEXT("Info"), MB_OK);
				SetClassLong(hWnd, GCL_STYLE, GetClassLong(hWnd, GCL_STYLE) | CS_DBLCLKS);
			}
			
			break;

		case WM_SHOWWINDOW:
			//MessageBox(hWnd, TEXT("Window visualization"), TEXT("Info"), MB_OK);
			break;

		case WM_CLOSE:
			RECT wr, cr;
			GetWindowRect(hWnd, &wr);
			GetClientRect(hWnd, &cr);
			/*wsprintf(str, TEXT("window: (x;y)=(%d;%d) width=%d height=%d\nclient: (x;y)=(%d;%d) width=%d height=%d"),
						wr.left, wr.top, wr.right - wr.left, wr.bottom - wr.top, 
						cr.left, cr.top, cr.right - cr.left, cr.bottom - cr.top);*/
			//MessageBox(hWnd, str, TEXT("Info"), MB_OK);
			if (MessageBox(hWnd, TEXT("Do you want to close the window?"), TEXT("Closing"), MB_YESNO) == IDYES)
				//DestroyWindow(hWnd);
				SendMessage(hWnd, WM_DESTROY, 0, 0);
				//PostMessage(hWnd, WM_QUIT, 0, 0);
			break;

		case WM_COMMAND:


			switch (LOWORD(wParam))
			{
				case ID�_BUTTON_IMAGE:
				case ID�_BUTTON_TEXT:
				
					ShowWindow(hWnd, SW_MINIMIZE);
					KillTimer(hWnd, IDT_TIMER1);
					break;
				case ID�_STATIC1:
					if (HIWORD(wParam) == STN_DBLCLK)
						//MessageBox(hWnd, TEXT("HELLO"), 0, 0);
						DestroyWindow((HWND)lParam);
					break;
				default:
					break;
			}

			break;
		case WM_TIMER:
		{

			time_t current_time = time(NULL);
			wsprintf(str, TEXT("%s"), _tctime(&current_time));
			SetWindowText(hWnd, str);

			BYTE red = rand() % 256;
			BYTE green = rand() % 256;
			BYTE blue= rand() % 256;
			SetClassLong(hWnd, GCL_HBRBACKGROUND, (LONG)CreateSolidBrush(RGB(red, green, blue)));
			InvalidateRect(hWnd, NULL, true);
			
		}
		break;

		case WM_DESTROY:		// ��������� � ���������� ���������
			PostQuitMessage(0); // ������� ��������� WM_QUIT 
			break;

		case WM_LBUTTONDOWN:
		{
	
			TCHAR cursor_position_str[50];
			wsprintf(cursor_position_str, TEXT("(X=%d;Y=%d)"), LOWORD(lParam), HIWORD(lParam));
			SetWindowText(hWnd, cursor_position_str);
			pDown = { LOWORD(lParam), HIWORD(lParam) };


		
		}
		break;
		case WM_LBUTTONUP:
		{

			pUp = { LOWORD(lParam), HIWORD(lParam) };
			POINT ltPoint{ 0,0 };

			if (abs(pDown.x - pUp.x) < 10 || abs(pDown.y - pUp.y) < 10)

				break;
			if (pUp.x > pDown.x && pUp.y > pDown.y)
				ltPoint = pDown;
			if (pUp.x < pDown.x && pUp.y < pDown.y)
				ltPoint = pUp;
			if (pUp.x < pDown.x && pUp.y > pDown.y)
				ltPoint = {pUp.x, pDown.y};
			if (pUp.x > pDown.x && pUp.y < pDown.y)
				ltPoint = { pDown.x, pUp.y };
			wsprintf(str, TEXT("%d"), ++stCounter);
			HWND hs= CreateWindowEx(0, TEXT("STATIC"), NULL, WS_CHILDWINDOW | WS_BORDER | WS_VISIBLE, ltPoint.x, ltPoint.y, abs(pDown.x - pUp.x), abs(pDown.y - pUp.y), hWnd, 0, GetModuleHandle(0), 0);
			SetWindowText(hs, str);


		}
		break;

		case WM_KEYDOWN:
			switch (wParam)
			{

			case 'Q':
				if (GetKeyState(VK_CONTROL)<0)
				{
					SetWindowText(hWnd, TEXT("->"));
					SendMessage(hWnd, WM_CLOSE, 0, 0);
				}
				break;

			case 'T':
			
				SetClassLong(hWnd, GCL_HCURSOR, (LONG)LoadCursor(NULL, IDC_CROSS));
				if (GetKeyState(VK_CONTROL)<0)
					SetTimer(hWnd, IDT_TIMER1, 1000, NULL);
				break;

			case 'B':
				if (GetKeyState(VK_CONTROL) < 0)
				{
					HWND hbutton_text=CreateWindowEx(WS_EX_TRANSPARENT,TEXT("BUTTON"),
						NULL, WS_BORDER|WS_CHILDWINDOW|WS_VISIBLE|BS_TEXT| BS_CENTER| BS_PUSHBUTTON, 50, 50, 200, 150,
						hWnd,(HMENU)ID�_BUTTON_TEXT,GetModuleHandle(0),0);
					SetWindowText(hbutton_text, TEXT("PRESS ME"));

					HWND hbutton_image = CreateWindowEx(WS_EX_TRANSPARENT, TEXT("BUTTON"), 
						NULL,WS_BORDER | WS_CHILDWINDOW | WS_VISIBLE | BS_BITMAP | BS_CENTER | BS_PUSHBUTTON, 250, 50, 250, 150, 
						hWnd, (HMENU)ID�_BUTTON_IMAGE, GetModuleHandle(0), 0);
					SendMessage(GetDlgItem(hWnd, ID�_BUTTON_IMAGE)/*hbutton_image*/, 
						BM_SETIMAGE, IMAGE_BITMAP, (LPARAM)LoadBitmap(GetModuleHandle(0), MAKEINTRESOURCE(IDB_BITMAP1)));
					
					
				}
				break;
			case 'S':
				if (GetKeyState(VK_CONTROL) < 0)
				{
					HWND hstatic = CreateWindowEx(0, TEXT("STATIC"), TEXT("static"),SS_NOTIFY| WS_BORDER | WS_CHILDWINDOW | WS_VISIBLE , 300, 50, 200, 150, hWnd, (HMENU)ID�_STATIC1, GetModuleHandle(0), 0);	
					//SendMessage(hstatic, WM_CTLCOLORSTATIC, (WPARAM)GetDC(hstatic), (LPARAM)hstatic);
					
				}
				break;
			case 'G':
				if (GetKeyState(VK_CONTROL) < 0)
				{
					RECT cl;
					GetClientRect(hWnd, &cl);
					EGradientDirection direction = (EGradientDirection)(rand() % 4);
					int cols = rand() % 1000 + 1;
					int red1 = rand() % 256;
					int green1 = rand() % 256;
					int blue1 = rand() % 256;
					int red2 = rand() % 256;
					int green2 = rand() % 256;
					int blue2 = rand() % 256;
					GradientFillRect(GetDC(hWnd), cl, RGB(red1, green1, blue1), RGB(red2, green2, blue2), cols, direction);
				}
				break;
			}
			break;
		case WM_CHAR:
		{
			if (wParam>='A' && wParam<='Z')
				MessageBox(hWnd, TEXT("upper case"), TEXT("Info"), MB_OK|MB_ICONINFORMATION);
			else if(wParam >= 'a' && wParam <= 'z')
				MessageBox(hWnd, TEXT("lower case"), TEXT("Info"), MB_OK|MB_ICONINFORMATION);
		
		
		}
		break;

	case WM_CTLCOLORSTATIC:
	{
		SetBkMode((HDC)wParam, TRANSPARENT);
		BYTE red = rand() % 256;
		BYTE green = rand() % 256;
		BYTE blue = rand() % 256;
		return (LRESULT)CreateSolidBrush(RGB(red, green, blue));
	}
	
	case WM_CTLCOLORBTN:
	{
		SetBkMode((HDC)wParam, TRANSPARENT);
		BYTE red = rand() % 256;
		BYTE green = rand() % 256;
		BYTE blue = rand() % 256;
		return (LRESULT)CreateSolidBrush(RGB(red, green, blue));
	}
		default:

		//	��� ���������, ������� �� �������������� � ������ ������� 
		//	������� ������������ ������� Windows �� ��������� �� ��������� 
		return DefWindowProc(hWnd, uMessage, wParam, lParam);

	}
	return 0;
}