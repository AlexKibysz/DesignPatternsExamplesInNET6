using PatronesEstructurales;

Menu menuDesayuno = new Menu("Desayuno", "Menu con todas las cosas ricas para desayunar...");

MenuItem tostadoMasCafe = new MenuItem("Tostado con Cafe", "sanguche de miga tostado, mas cafe expresso cortado", false);

MenuItem tostadoMasTe = new MenuItem("Tostado con Te", "sanguche de miga tostado, mas cafe expresso cortado", false);

menuDesayuno.addMenuComponent(tostadoMasCafe);
menuDesayuno.addMenuComponent(tostadoMasTe);

Menu menuAlmuerzo = new Menu("Almuerzo", "Menu con todas las cosas ricas para almorzar...");


MenuItem rissotoTapaNalga = new MenuItem("Rissoto con Tapa de Nalga",
    "Una porcion de rissoto con un pedazo de tapa de nalga al horno decorado con finas hierbas", false);

MenuItem ensaladaCesar = new MenuItem("Ensalada Cesar", "Lechuga, mayonesa, Croutones para que te sientas como el cesar", true);

menuAlmuerzo.addMenuComponent(rissotoTapaNalga);

menuAlmuerzo.addMenuComponent(ensaladaCesar);

menuAlmuerzo.removeMenuComponent(rissotoTapaNalga);

Menu menuCena = new Menu("Cena", "Menu con todas las cosas ricas para Cenar...");

MenuItem asado = new MenuItem("Asado", "2 chori, 2 chinchu, 1 Costillar, 1 matambrito", false);

menuCena.addMenuComponent(asado);


Menu menuCompleto = new Menu("Menu Completo", "Menu Completo de la casa");

menuCompleto.addMenuComponent(menuDesayuno);
menuCompleto.addMenuComponent(menuAlmuerzo);
menuCompleto.addMenuComponent(menuCena);


menuCompleto.print();