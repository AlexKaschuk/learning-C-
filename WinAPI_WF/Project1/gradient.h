#pragma once
#include<windows.h>
enum EGradientDirection { gdTopBottom, gdLeftRight, gdBottomTop, gdRightLeft };

void GradientFillRect(HDC _pDC,                     //�������� ���������� 
	RECT _rect,                   //������� �������
	COLORREF _startCol,           //��������� ���� �������
	COLORREF _endCol,             //�������� ���� �������
	int _cols,                    //���������� ��������� �����
	EGradientDirection Direction); //����������� �������

