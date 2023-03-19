#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main()
{
	
	int piezas[] = {1, 2, 3, 4, 5, 6, 7};
	int pieza_Anterior = 0;
	int pieza_Actual;
	int cont = 0;
	
	srand(time(NULL));
	
	for(int i = 0; i < 7; i++)
	{
		do
		{
			pieza_Actual = piezas[rand() % 7];
			cont++;
			
		}while (pieza_Actual == pieza_Anterior);
		
		printf("La pieza %d ha salido en el intento numero %d\n", pieza_Actual, cont);
	}
	
	return 0;
}
