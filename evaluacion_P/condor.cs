using System;

namespace program
{
  class condor:ave
  {
   
    public condor (string nombre){
        nombre_condor=nombre;
    }
public override void getNombre()
{
    Console.WriteLine("el nombre del condor  es"+nombre_condor);
}
public override void swim()
{
    Console.WriteLine("el condor no nada");
}
public override void fly()
{
    Console.WriteLine("el condor si vuela");
}
private string nombre_condor;
  }

}