#define _CRT_SECURE_NO_WARNINGS
#include <windows.h> 
#include <tchar.h> 
#include <time.h> 
#include"resource.h"
#include"gradient.h"

//прототип оконной процедуры
LRESULT CALLBACK WindowProc(HWND, UINT, WPARAM, LPARAM);




											   //	INT WINAPI WinMain(
											   //	HINSTANCE hInst,		//	дескриптор экземпляра приложения
											   //	HINSTANCE hPrevInst,	//	равен 0 и необходим для совместимости
											   //	LPSTR	lpszCmdLine,	//	указатель  на  строку,  в  которую  копируются
											   //							//	аргументы приложения, если оно запущено в режиме командной строки 
											   //	int nCmdShow			//	способ визуализации окна при запуске программы
											   
											   //	int nCmdShow:
											   //	SW_HIDE				Скрывает окно и активизирует другое окно.
											   //	SW_MAXIMIZE			Распахивает указанное окно на весь экран.
											   //	SW_MINIMIZE			Минимизирует указанное окно и активизирует следующее окно верхнего уровня Z буфера.
											   //	SW_RESTORE			Активизирует и отображает окно.Если окно минимизировано или развернуто, система восстанавливает его в исходное положение и размер.Приложение должно указать этот флаг при восстановлении свернутого окна.
											   //	SW_SHOW				Активирует окно и выводит на экран это в его текущем размере и позиции.
											   //	SW_SHOWMAXIMIZED	Активизирует окно и отображает его как развернутое окно.
											   //	SW_SHOWMINIMIZED	Активизирует окно и отображает его как свернутое окно.
											   //	SW_SHOWMINNOACTIVE	Отображает окно как свернутое окно.Это значение аналогично SW_SHOWMINIMIZED, за исключением того, что окно не активизируется.
											   //	SW_SHOWNA			Отображает окно в его текущем размере и позиции.Это значение аналогично SW_SHOW, за исключением того, что окно не активизируется.
											   //	SW_SHOWNOACTIVATE	Отображает окно в его последнем размер и положение.Это значение аналогично SW_SHOWNORMAL, за исключением того, что окно не активируется.
											   //	SW_SHOWNORMAL		Активизирует и отображает окно.Если окно минимизировано или развернуто, система восстанавливает его в исходное положение и размер.Приложение должно указать этот флаг при показе окна в первый раз.

//точка входа
INT WINAPI WinMain(HINSTANCE hInst, HINSTANCE hPrevInst, LPSTR lpszCmdLine, int nCmdShow)
{
	srand(time(NULL));
	WNDCLASSEX wcl;					//	Структура WNDCLASSEX содержит информацию о классе окна. Она используется с функциями RegisterClassEx и GetClassInfoEx. 
									//typedef struct
									//{
									//	UINT  cbSize;					//	Устанавливает размер этой структуры, в байтах. Устанавливайте этот член структуры в sizeof (WNDCLASSEX). Убедитесь, что установили этот член структуры перед вызовом функции GetClassInfoEx
									//	UINT  style;					//	Стиль окна определяется комбинацией нескольких предопределенных констант. Довольно часто он задается равным нулю, что означает “стиль по умолчанию”
									//	WNDPROC  lpfnWndProc;			//	Указатель на оконную процедуру.  Вы должны использовать функцию CallWindowProc, чтобы вызвать оконную процедуру
									//	int  cbClsExtra;				//	Определяет количество дополнительных байт резервируемых структуре класса.
									//	int  cbWndExtra;				//	Определяет количество дополнительных байт резервируемых структуре окна.
									//	HINSTANCE  hInstance;			//	Дескриптор экземпляра, который содержит оконную процедуру для класса.
									//	HICON  hIcon;					//	Дескриптор иконки. Этот элемент должен содержать дескриптор ресурса иконки. Если этот элемент имеет значение NULL, система устанавливает значок по умолчанию.
									//	HCURSOR  hCursor;				//	Дескриптор курсора. Этот элемент должен содержать дескриптор ресурса курсора. Если этот элемент имеет значение NULL, приложение должно явно установить формы курсора при перемещении мыши в окне приложения.
									//	HBRUSH  hbrBackground;			//	Дескриптор кисти фона. Этот элемент может быть дескриптором кисти, которая будет использоваться для окраски фона, или это может быть значение цвета.
									//	LPCTSTR  lpszMenuName;			//	Указатель на имя ресурса меню. Если этот элемент имеет значение NULL, окна этого класса не имеют меню.
									//	LPCTSTR  lpszClassName;			//	Указатель имя только что созданного класса окна. Максимальная длина lpszClassName 256.
									//	HICON  hIconSm;					//	Дескриптор маленького значка, который связан с классом окна. Если этот член структуры - ПУСТО (NULL), система ищет ресурс значка, определенный членом структуры hIcon для значка соответствующего размера, чтобы использовать как маленький значок.
									//	} WNDCLASSEX, *PWNDCLASSEX;



//1. Определение класса окна
	TCHAR szClassWindow[] = TEXT("MainWindow"); /* Имя класса окна */
	wcl.cbSize = sizeof(WNDCLASSEX);    // размер структуры WNDCLASSEX
	wcl.style = CS_HREDRAW | CS_VREDRAW|CS_DBLCLKS;//Перерисовать всё окно, если изменён размер по горизонтали или по вертикали  // CS(Class Style) - стиль класса окна
	wcl.lpfnWndProc = WindowProc;		// адрес оконной процедуры
	wcl.cbClsExtra = 0;					// используется Windows
	wcl.cbWndExtra = 0;					// используется Windows
	wcl.hInstance = hInst;				// дескриптор данного приложения
										// загрузка стандартной иконки
	wcl.hIcon =									LoadIcon(NULL, IDI_APPLICATION); 
												//(HICON)LoadIcon(GetModuleHandle(0), MAKEINTRESOURCE(IDI_ICON3));
												//(HICON)LoadImage(NULL, TEXT("my_icon.ico"), IMAGE_ICON, 0, 0, LR_DEFAULTSIZE | LR_LOADFROMFILE);
																						 
											// загрузка стандартного курсора 
	wcl.hCursor =							//LoadCursor(NULL, IDC_ARROW);  

											//LoadCursor(GetModuleHandle(0), MAKEINTRESOURCE(IDC_CURSOR1)); 
											LoadCursorFromFile(TEXT("left_ptr.cur"));// ;
	wcl.hbrBackground = CreateSolidBrush(RGB(115, 110, 250)); //(HBRUSH)GetStockObject(DEFAULT_PALETTE);// заполнение окна белым цветом
	wcl.lpszMenuName = NULL;			//приложение не содержит меню 
	wcl.lpszClassName = szClassWindow;	//имя класса окна 
	wcl.hIconSm = NULL;					// отсутствие маленькой иконки

	HWND hWnd;							//дескриптор окна
	MSG msg;

//2. Регистрация класса окна
	if (!RegisterClassEx(&wcl))
		return -1;				// при неудачной регистрации - выход
	
//3. Создание окна 

	hWnd = CreateWindowEx(		// создается окно и переменной hWnd присваивается дескриптор окна 
		0,						// расширенный стиль окна
		szClassWindow,			// имя класса окна
		TEXT("INTRODUCTION TO WINAPI"),	// заголовок окна
		WS_OVERLAPPEDWINDOW,	// стиль окна ( Заголовок, рамка, позволяющая менять размеры, системное меню, кнопки развёртывания и свёртывания окна )
		CW_USEDEFAULT,			// х-координата левого верхнего угла окна
		CW_USEDEFAULT,			// y-координата левого верхнего угла окна
		CW_USEDEFAULT,			// ширина окна
		CW_USEDEFAULT,			// высота окна
		NULL,					//GetDesktopWindow()  дескриптор родительского окна
		NULL,					// дескриптор меню окна (ID окна)
		hInst,					// идентификатор приложения, создавшего окно
		NULL);					// указатель на область данных приложения


//4. Отображение окна
	ShowWindow(hWnd, nCmdShow);
//5. Перерисовка окна
	UpdateWindow(hWnd);



//6. Запуск цикла обработки сообщений			
	while (GetMessage(&msg,NULL, 0, 0))// получение очередного сообщения из очереди сообщений 
	{
		TranslateMessage(&msg);	// трансляция сообщения
		DispatchMessage(&msg);	// диспетчеризация сообщений
	}

//6. Выход из WinMain
	return 0;
}




//Оконная процедура
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
				case IDС_BUTTON_IMAGE:
				case IDС_BUTTON_TEXT:
				
					ShowWindow(hWnd, SW_MINIMIZE);
					KillTimer(hWnd, IDT_TIMER1);
					break;
				case IDС_STATIC1:
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

		case WM_DESTROY:		// сообщение о завершении программы
			PostQuitMessage(0); // посылка сообщения WM_QUIT 
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
						hWnd,(HMENU)IDС_BUTTON_TEXT,GetModuleHandle(0),0);
					SetWindowText(hbutton_text, TEXT("PRESS ME"));

					HWND hbutton_image = CreateWindowEx(WS_EX_TRANSPARENT, TEXT("BUTTON"), 
						NULL,WS_BORDER | WS_CHILDWINDOW | WS_VISIBLE | BS_BITMAP | BS_CENTER | BS_PUSHBUTTON, 250, 50, 250, 150, 
						hWnd, (HMENU)IDС_BUTTON_IMAGE, GetModuleHandle(0), 0);
					SendMessage(GetDlgItem(hWnd, IDС_BUTTON_IMAGE)/*hbutton_image*/, 
						BM_SETIMAGE, IMAGE_BITMAP, (LPARAM)LoadBitmap(GetModuleHandle(0), MAKEINTRESOURCE(IDB_BITMAP1)));
					
					
				}
				break;
			case 'S':
				if (GetKeyState(VK_CONTROL) < 0)
				{
					HWND hstatic = CreateWindowEx(0, TEXT("STATIC"), TEXT("static"),SS_NOTIFY| WS_BORDER | WS_CHILDWINDOW | WS_VISIBLE , 300, 50, 200, 150, hWnd, (HMENU)IDС_STATIC1, GetModuleHandle(0), 0);	
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

		//	все сообщения, которые не обрабатываются в данной оконной 
		//	функции направляются обратно Windows на обработку по умолчанию 
		return DefWindowProc(hWnd, uMessage, wParam, lParam);

	}
	return 0;
}