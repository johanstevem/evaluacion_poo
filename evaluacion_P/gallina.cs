using System;

namespace program
{
  class gallina:ave
  {
   
    public gallina (string nombre){
        nombre_gallina=nombre;
    }
public override void getNombre()
{
    Console.WriteLine("el nombre de la gallinita es"+nombre_gallina);
}
public override void swim()
{
    Console.WriteLine("la gallina no nada :(");
}
public override void fly()
{
    Console.WriteLine("la gallina no vuela solo planea");
}
private string nombre_gallina;
  }

}