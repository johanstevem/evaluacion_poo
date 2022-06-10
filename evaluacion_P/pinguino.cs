using System;

namespace program
{
  class pinguino:ave
  {
   
    public pinguino (string nombre){
        nombre_pinguino=nombre;
    }
public override void getNombre()
{
    Console.WriteLine("el nombre del pinguino es"+nombre_pinguino);
}
public override void swim()
{
    Console.WriteLine("el pinguino nada");
}
public override void fly()
{
    Console.WriteLine("el pinguino no vuela :(");
}
private string nombre_pinguino;
  }

}