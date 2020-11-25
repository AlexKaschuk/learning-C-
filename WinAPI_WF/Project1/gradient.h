#pragma once
#include<windows.h>
enum EGradientDirection { gdTopBottom, gdLeftRight, gdBottomTop, gdRightLeft };

void GradientFillRect(HDC _pDC,                     //Контекст устройства 
	RECT _rect,                   //Область заливки
	COLORREF _startCol,           //Начальный цвет заливки
	COLORREF _endCol,             //Конечный цвет заливки
	int _cols,                    //Количество переходов цвета
	EGradientDirection Direction); //Направление заливки

