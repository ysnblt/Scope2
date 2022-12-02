// See https://aka.ms/new-console-template for more information

int x = 100;
Başla();

void Başla()
{
    
    Console.WriteLine("x ilk değeri" + x);
    IkiyeKatla(x);
    Console.WriteLine("x metoddan döndükten sonrası değeri" + x);

}

void IkiyeKatla(int a)
{
    a = a * 2;
    Console.WriteLine("x metod içi değeri" + a);
}
