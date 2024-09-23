using PatronesEstructurales;

BigMac bigMac = new BigMac();

BigMacDecorator bigMacCompleto = new extraBacon(bigMac);

BigMacDecorator bigMacCompleto1 = new extraCheddar(bigMacCompleto);

BigMacDecorator bigMacCompleto2 = new extraCarne(bigMacCompleto1);

Console.WriteLine($"{bigMacCompleto1.descripcion()}" +
    $" y el prcio es de {bigMacCompleto1.precio()}");



