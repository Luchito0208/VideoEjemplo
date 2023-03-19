#include <stdio.h>

int main()
{
	char letra = 'a';
	short num1 = -127;
	int num2 = 100;
	unsigned int num3 = 1024;
	long num4 = 1234567;
	float num5 = 3.1416;
	double num6 = 123456.78910;
	
	printf("El caracter (char) es la letra: %c", letra);
	printf("\nEl numero (short) es igual a: %i", num1);
	printf("\nEl numero (int) es igual a: %i", num2);
	printf("\nEl numero (unsigned int) es igual a: %i", num3);
	printf("\nEl numero (long) es igual a: %li", num4);
	printf("\nEl numero (float) es igual a: %.4f", num5);
	printf("\nEl numero (double) es igual a: %lf", num6);
	
	return 0;
}
