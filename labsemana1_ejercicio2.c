# include <stdio.h>
# include <math.h>

int main()
{
	int num1, result1, result2, result3, result5;
	
	float result4;
	
	printf("Ingrese un numero entero: ");
	scanf("%i", &num1);
	
	result1 = num1 + 4;
	
	result2 = num1 - 2;
	
	result3 = num1 * 3;
	
	result4 = (float) num1 / 5;
	
	result5 = pow(num1, 3);
	
	printf("\nLa suma del numero %i mas 4 es igual a: %i", num1, result1);
	printf("\nLa resta del numero %i menos 2 es igual a: %i", num1, result2);
	printf("\nLa multiplacion del numero %i por 3 es igual a: %i", num1, result3);
	printf("\nLa division del numero %i entre 5 es igual a: %.2f", num1, result4);
	printf("\nEl numero %i elevado al cubo es igual a: %i", num1, result5);
}

