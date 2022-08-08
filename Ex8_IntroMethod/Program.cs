int a1 = 25;
int b1 = 15;
int c1 = 56;
int a2 = 82;
int b2 = 12;
int c2 = 45;
int a3 = 74;
int b3 = 73;
int c3 = 19;

int max = a1;
if(b1 > max) max = b1;
if(c1 > max) max = c1;

if(a2 > max) max = a2;
if(b2 > max) max = b2;
if(c2 > max) max = c2;

if(a3 > max) max = a3;
if(b3 > max) max = b3;
if(c3 > max) max = c3;

Console.WriteLine(max);