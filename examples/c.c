#include <stdio.h>

struct test {
    int x;
    int y;
};
int main()
{
    int a,b,i,j;
    printf("please enter the size of the table");
    scanf("%d",&a);
    for (i=0;i<=a;i++)
    {
        for(j=0;j<=i;j++)
        {
            printf("%d*%d=%d",i,j,i*j);
        }
        printf("\n");
    }
}