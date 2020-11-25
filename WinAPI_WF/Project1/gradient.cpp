#include "gradient.h"

void GradientFillRect(HDC _pDC, RECT _rect, COLORREF _startCol, COLORREF _endCol, int _cols, EGradientDirection Direction)
{
	//Проверка на пустой рект
	if (_rect.bottom == _rect.top || _rect.left == _rect.right)    return;

	HBRUSH Brush;

	//Если меньше 2х переходов цвета закрашиваем начальным цветом
	if (_cols  < 2)
	{
		Brush = CreateSolidBrush(_startCol);
		FillRect(_pDC, &_rect, Brush);
		DeleteObject(Brush);
		return;
	}

	//Если тип заливки gdBottomTop или gdRightLeft то меняем цвета местами
	//и объявляем направление gdTopBottom или gdLeftRight соответственно
	if (Direction == gdBottomTop || gdRightLeft)
	{
		COLORREF _tmp = _startCol;
		_startCol = _endCol;
		_endCol = _tmp;
		switch (Direction)
		{
		case gdBottomTop:    Direction = gdTopBottom;    break;
		case gdRightLeft:    Direction = gdLeftRight;    break;
		}
	}

	BYTE StartR;
	BYTE StartG;
	BYTE StartB;
	int DeltaR;
	int DeltaG;
	int DeltaB;

	RECT ColorBand;
	int i, Delta;

	StartR = GetRValue(_startCol);
	StartG = GetGValue(_startCol);
	StartB = GetBValue(_startCol);

	DeltaR = GetRValue(_endCol) - StartR;
	DeltaG = GetGValue(_endCol) - StartG;
	DeltaB = GetBValue(_endCol) - StartB;

	ColorBand = _rect;

	switch (Direction)
	{
	case gdTopBottom:
	{
		_cols = max(2, min(_cols, (_rect.bottom - _rect.top)));
		Delta = (int)((_rect.bottom - _rect.top) / _cols);
	}
	break;
	case gdLeftRight:
	{
		_cols = max(2, min(_cols, (_rect.right - _rect.left)));
		Delta = (int)((_rect.right - _rect.left) / _cols);
	}
	break;
	}

	//Закраска основной поверхности
	if (Delta>0)
	{
		for (i = 0; i < _cols; ++i)
		{
			switch (Direction)
			{
			case gdTopBottom:
			{
				ColorBand.top = _rect.top + i * Delta;
				ColorBand.bottom = ColorBand.top + Delta;
			}
			break;
			case gdLeftRight:
			{
				ColorBand.left = _rect.left + i * Delta;
				ColorBand.right = ColorBand.left + Delta;
			}
			break;
			}

			Brush = CreateSolidBrush(RGB(
				StartR + MulDiv(i, DeltaR, _cols - 1),
				StartG + MulDiv(i, DeltaG, _cols - 1),
				StartB + MulDiv(i, DeltaB, _cols - 1)));
			FillRect(_pDC, &ColorBand, Brush);
			DeleteObject(Brush);
		}
	}

	div_t Res;
	switch (Direction)
	{
	case gdTopBottom:    Res = div((int)(_rect.bottom - _rect.top), (int)_cols);    break;
	case gdLeftRight:    Res = div((int)(_rect.right - _rect.left), (int)_cols);    break;
	}
	Delta = Res.rem;
	if (Delta > 0)
	{
		for (i = 0; i < _cols; ++i)
		{
			switch (Direction)
			{
			case gdTopBottom:
			{
				ColorBand.top = _rect.bottom - Delta;
				ColorBand.bottom = ColorBand.top + Delta;
			}
			break;
			case gdLeftRight:
			{
				ColorBand.left = _rect.right - Delta;
				ColorBand.right = ColorBand.left + Delta;
			}
			break;
			}
			Brush = CreateSolidBrush(_endCol);
			FillRect(_pDC, &ColorBand, Brush);
			DeleteObject(Brush);
		}
	}
}