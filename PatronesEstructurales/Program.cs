using PatronesEstructurales;

BigMac bigMac = new BigMac();

IHamburgesa bigMacCompleto = new extraBacon(bigMac);

IHamburgesa bigMacCompleto1 = new extraCheddar(bigMacCompleto);

IHamburgesa bigMacCompleto2 = new extraCarne(bigMacCompleto1);

Console.WriteLine($"{bigMacCompleto2.descripcion()}",
    " y el prcio es de", $"{bigMacCompleto2.precio().ToString()}");
