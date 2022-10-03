using DesafioPOO.Models;

Nokia celularNokia = new Nokia( "+55(19)91923-1234", "Nokia 5.4", "123456789012345/00", 128 );
celularNokia.Ligar("(19)91923-1234");
celularNokia.InstalarAplicativo("dio.me");

Iphone iPhone = new Iphone("+55(19)91923-1299", "IPhone 13 PRO", "923456789012345/00", 256);
iPhone.InstalarAplicativo("dio.me");
iPhone.Ligar("(19)91923-1234");
celularNokia.ReceberLigacao("(19)91923-1299");
