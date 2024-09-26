// See https://aka.ms/new-console-template for more information
using PatronesCombinados.CompositeIterator;
using PatronesCombinados.SimplerCompositeIterator.ConcreteComposite;
using PatronesCombinados.SimplerCompositeIterator.Leaf;

Console.WriteLine("==============SIMPLER COMPOSITE ITERATOR=================");
var raiz = new Composite("Raíz");
var hoja1 = new Hoja("Hoja 1");
var hoja2 = new Hoja("Hoja 2");

var subCompuesto = new Composite("SubCompuesto");
subCompuesto.Agregar(new Hoja("Hoja 3"));

raiz.Agregar(hoja1);
raiz.Agregar(hoja2);
raiz.Agregar(subCompuesto);

var iterador = raiz.CrearIterador();
while (iterador.TieneSiguiente())
{
    var componente = iterador.Siguiente();
    componente.Mostrar(1);
}


Console.WriteLine("==============COMPLEX COMPOSITE ITERATOR=================");
CompositeIteratorExample.Run();