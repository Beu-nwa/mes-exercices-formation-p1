using extensionsdeclass;
using System;

int a = 10;
int b = 20;
int c;

// c = a + b;
c = Extension.Additionner(a,b);

double d = 3.25;
double e = 1.75;

double f = d.Additionner2(e);
