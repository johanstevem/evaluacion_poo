using System;

namespace evaluacio_P
{
class program
{
static void Main(string [] args)
{
    gallina ob_gallina= new gallina("clara");
    ob_gallina.getNombre();
    ob_gallina.fly();
    ob_gallina.swim();

    Condor ob_condor= new Condor("condorito");
    ob_condor.getNombre();
    ob_condor.fly();
    ob_condor.swim();

     pato ob_pato= new pato("Donald");
    ob_pato.getNombre();
    ob_pato.fly();
    ob_pato.swim();

     pinguino ob_pinguino= new pinguino("felix");
    ob_pinguino.getNombre();
    ob_pinguino.fly();
    ob_pinguino.swim();
}
}

}