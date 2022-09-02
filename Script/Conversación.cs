using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conversación : MonoBehaviour
{
    //Booleanos para las decisiones
    bool D1, D2, D3, D4, D5, D6, D7, D8, D9;

    // Start is called before the first frame update
    void Start()
    {
        //Inicializo la ramificación de conversaciones
        C1(0);
    }

    // Update is called once per frame
    void Update()
    {
        //Dependiendo de en punto de la conversación estemos, dandole al 1, 2 o 3 nos llevara a tomar las decisiones y así solo activarlo en el punto que estemos.
        //La estructura es basica, el boolean se activa cuando entramos en diferentes conversaciones y así aun que le demos no se activan otras partes.
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
        {
            if(D1 == true)
            {
                C1(1);
            }
            else if(D2 == true)
            {
                C2(1);
            }
            else if (D3 == true)
            {
                C3(1);
            }
            else if (D4 == true)
            {
                C4(1);
            }
            else if (D5 == true)
            {
                C14(1);
            }
            else if (D6 == true)
            {
                C15(1);
            }
            else if (D7 == true)
            {
                C16(1);
            }
            else if (D8 == true)
            {
                C17(1);
            }
            else if (D9 == true)
            {
                C18(1);
            }
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            if (D1 == true)
            {
                C1(2);
            }
            else if (D2 == true)
            {
                C2(2);
            }
            else if (D3 == true)
            {
                C3(2);
            }
            else if (D4 == true)
            {
                C4(2);
            }
            else if (D5 == true)
            {
                C14(2);
            }
            else if (D6 == true)
            {
                C15(2);
            }
            else if (D7 == true)
            {
                C16(2);
            }
            else if (D8 == true)
            {
                C17(2);
            }
            else if (D9 == true)
            {
                C18(2);
            }
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
        {
            if (D1 == true)
            {
                C1(3);
            }
            else if (D2 == true)
            {
                C2(3);
            }
            else if (D3 == true)
            {
                C3(3);
            }
            else if (D4 == true)
            {
                C4(3);
            }
            else if (D9 == true)
            {
                C18(3);
            }
        }
    }
    void C1(int x)
    {
        D1 = true;
        //Comienzo de las decisiones

        if (x == 0)
        {
            MyDebug("Uff que sueño mas raro he tenido la verdad y encima son las 7:32 me debería levantar ya y ducharme, si no voy a llegar tarde al curro");
            MyDebug("*Una ducha rapida despues*");
            MyDebug("Vale a ver, hoy que me pongo para ir to bacanote?? A ver, a ver que tenemos por aquí...");
            MyDebug("Ummm polito rosa, con el chino este y unos nauticos? Pijito total o que?");
            MyDebug("Huy yu yui y si hoy voy rollo streetwear y me pongo la sudadera Supreme, estos pantalones negros y las Jordans?");
            MyDebug("Bueno bueno y si voy rollo Skater y me pongo el polito negro con la sudadera por encima, con los vaqueros y las vans?");
            MyDebug("Que ropa me pongo? 1.Polito rosa 2.StreetWear 3.Skater");
            MyDebug("*Para elejir outfit pulsa 1, 2 o 3*");
        }
        else if (x == 1)
        {
            MyDebug("Voy a ponerme el polito rosa");
            D1 = false;
            C2(0);
            
        }
        else if (x == 2)
        {
            MyDebug("Voy a ir rollito StreetWear hoy");
            C3(0);
            D1 = false;
        }
        else if(x == 3)
        {
            MyDebug("Voy a modo skater hoy que me apetece");
            C4(0);
            D1 = false;
        }
    }
    void C2(int x)
    {
        D2 = true;

        if (x == 0)
        {
            MyDebug("Madre mía que pijito voy hoy no? Bueno una al año no hace daño jajaja");
            MyDebug("Bueno debería irme ya a currar que estoy hasta arriba con el proyecto , de camino podría pasarme a mirar se me ha tocado algo en la bonoloto," +
                " y siento como si me estuviese olvidando de algo");
            MyDebug("ostia claro hoy es el cumple de mi pareja tendría que ir a verla no? aun que bueno luego tenemos cena con sus padres");
            MyDebug("Que debería hacer? 1.Mirar la bonoloto de camino al curro 2.Ir a ver a la novia 3.Irme a trabajar ");
        }
        else if (x == 1)
        {
            MyDebug("Va miro si me ha tocado algo en la loteria y así si he ganado algo puedo invitarles a la cena entera a mis suegros y mi novia por su cumple");
            MyDebug("*Me voy a mirar la Loteria");
            D2 = false;
            C5();
        }
        else if (x == 2)
        {
            MyDebug("A ver tengo que ser buen novio e ir a verla");
            MyDebug("Voy y la hago una visita sorpresa fugaz, por un día que llegue tarde al curro no pasa nada");
            D2 = false;
            C6();
        }
        else if (x == 3)
        {
            MyDebug("Se que es su cumple pero es más importante el trabajo, ademas de que cuando acabe la compro algo bonito y luego tengo la cena con sus papas");
            MyDebug("*Me voy al curro directito");
            D2 = false;
            C7();
        }
    }
    void C3(int x)
    {
        D3 = true;

        if (x == 0)
        {
            MyDebug("Oye que piquete llevo no? Bueno con lo que me costaron las jordan y la sudadera no es para menos jajaja");
            MyDebug("Puff debería irme a currar pero tengo un hambre que te cagas y si mejor me voy a desayunar, tengo que llamar a Paco que me dijo que tenia lago importante que decirme" +
                " aunque le podría llamar dando un paseo hasta el curro que me vendrá bien para despejarme ");
            MyDebug("Que debería hacer? 1.Ir a desayunar 2.Ir al curro paseando mientras llamo a Paco 3.Llamar a Paco ya");
        }
        else if (x == 1)
        {
            MyDebug("Me voy a desayunar pero ya, luego haré todo lo demás");
            MyDebug("Buah encima tengo aquí al lado la pasteleria que ganó un premio el año pasado por la mejor cheesecake y me apetece probarla");
            MyDebug("*Me voy hasta la pastelería*");
            D3 = false;
            C8();
        }
        else if (x == 2)
        {
            MyDebug("Va desayuno en el curro y me voy dando un paseo así me entra mas hambre y encima puedo ir hablando tranquilamente con Paco");
            MyDebug("*Salgo hacia el curro*");
            D3 = false; 
            C9();
        }
        else if (x == 3)
        {
            MyDebug("Voy a llamar a Paco ya a ver si va a ser algo importante");
            MyDebug("A ver, a ver, Paco, Paco, aquí está el bueno de Paco Mermela");
            MyDebug("*Llamar*");
            D3 = false;
            C10();
        }
    }
    void C4(int x)
    {
        D4 = true;
        if (x == 0)
        {
            MyDebug("Llevar este outfit siempre me recuerda a mi etapa en el instituto, que epoca aquella");
            MyDebug("Bueno, debería ponerme con el proyecto del curro aun que en verdad hoy puedo hacerlo desde casa," +
                " aunque ostia hoy es el cumple de mi novia tendría que ir a comprarla algo");
            MyDebug("*Suena telefono*: Llamada entrante de Aamama");
            MyDebug("Ostia me está llamando mi madre");
            MyDebug("Que hago? 1.Currar desde casa 2.Cogerle el movil a mi madre 3.Buscar algo para comprarle a la novia");
        }
        else if (x == 1)
        {
            MyDebug("Estoy hasta arriba con el proyecto, luego llamo a mi madre y miro que comprarle a la chorba");
            MyDebug("*Me pongo a currar desde casa*");
            D4 = false;
            C11();
        }
        else if (x == 2)
        {
            MyDebug("*Cojo el telefono*");
            MyDebug("-Madre: Buneos días hijo, que tal estas? Y la novia?");
            MyDebug("-Buenos mama, pues aquí andamios, me iba a poner a currar desde casa. Y la novia, hoy es su cumple luego cuando acabe me iré a verla que tenemos cena con sus padres");
            MyDebug("-Mama: Hijo pero vete a verla ahora, si no tienes que trabajr desde casa obligatoriamente y ademas te pilla de camino");
            MyDebug("-Ya lo había pensado pero es que tengo que avanzar bastante y si empiezo ya desde casa mejor");
            MyDebug("-Mama: Hijos yo no he enseñado esos valores, vete a verla hombre tienes que cuidar a tu pareja que si no luego te arrepentiras");
            MyDebug("-Vale mama me voy a verla, luego te llamo, te quiero chao");
            MyDebug("-Mama: Venga hijo disfruta, adios");
            MyDebug("*Cuelgo*");
            MyDebug("Bueno vamonos para allá");
            D4 = false;
            C12();
        }
        else if (x == 3)
        {
            MyDebug("En verdad podría ir comprarla algo, aun que sea un pastelito en su pastelería favorita");
            MyDebug("*Me voy en busca de una tarta*");
            D4 = false;
            C13();
        }
    }
    void C5()
    {
        MyDebug("No se por que siento una buena vibra con este boleto la verdad, voy muy confiado la verdad");
        MyDebug("*Llego al local de la loteria*");
        C16(0);
    }
    void C6()
    {
        MyDebug("Buah seguro que no se lo espera, le va a encantar");
        MyDebug("*En camino de casa de la novia*");
        C18(0);
    }
    void C7()
    {
        MyDebug("Asi que mejor me voy al curro directo y sigo con el proyecto");
        MyDebug("*Voy hasta la oficina a currar*");
        C15(0);
    }
    void C8()
    {
        MyDebug("Mira ya he llegado, uf que pintaza la cheesecake");
        MyDebug("*Me compro un trozo de cheesecake y me lo como*");
        MyDebug("La verdad que tienen un monton de pasteles");
        MyDebug("*Observo los pasteles*");
        C14(0);
    }
    void C9()
    {
        MyDebug("Bueno que buen día hace hoy la verdad, debería ir mas veces andando al curro en vez de en moto");
        MyDebug("Voy a llamar al Paquito a ver que quiere");
        MyDebug("*Aparece un hombre con una vestimenta rara*");
        MyDebug("-Hombre raro: Nooo no llames a Paco");
        MyDebug("-Que coño? Quien eres tú?");
        MyDebug("-HR: Eso ahora no importa, solamente no le llames y te lo explico todo");
        MyDebug("-Tú estas loco? Dejame en paz drogadicto");
        MyDebug("-HR: Vale se que no me vas a creer, pero soy tu hijo del futuro");
        MyDebug("-Como? Me estas vacilando?");
        MyDebug("-HR: Te lo prometo dejame explicarme");
        MyDebug("-Vale venga explicate");
        MyDebug("-HR: Vamos a un sitio mas privado");
        MyDebug("*Nos vamos a casa*");
        C17(0);
    }
    void C10()
    {
        MyDebug("*Paco coje el telefono*");
        MyDebug("-Paco: Que pasa tio, por fin me llamas poco mas y te tengo que ir a buscar");
        MyDebug("-Ya tio, mucho lio ultimamente, bueno que era eso importante que me tenias que decir?");
        MyDebug("-Paco: Vale mira, el otro día fui a ver a una vidente y entre otras cosas me dijo que hoy tendría la mayor suerte de mi vida, ademas de que me ha dado los" +
            " numeros ganadores de la lotería de hoy y claro compré dos boletos y lo quería compartir contigo");
        MyDebug("-Que dices tú? Vas borracho ya?");
        MyDebug("-Paco: Que no bro te lo juro, mira quedamos en la loteria al lado de tu curro y comprobamos el numero y si no es no me debes nada, así no tienes nada que perder");
        MyDebug("-A ver si me lo pintas así, vale nos vemos alli aun que me sigue pareciendo raro");
        MyDebug("-Paco: Va pues nos vemos alli");
        MyDebug("*Colgamos y me dirijo hacia allá*");
        MyDebug("-Que pasa paco");
        MyDebug("-Paco: Que bueno verte, mira aquí tienes el boleto y yo ya he mirado si ha tocado o no. Metete y miralo, y ya luego me dsa las gracias si eso");
        MyDebug("-Ummm vale, pero ha tocado?");
        MyDebug("-Paco: Que lo mires por ti mismo pestucio");
        MyDebug("*Entro al local de loteria*");
        C16(0);
    }
    void C11()
    {
        MyDebug("Bueno tocca ponerse con este proyecto, esperemos que mi jefe no me toque las narices mientras trabajo en él.");
        MyDebug("*Me pongo a trabajar*");
        C15(0);
    }
    void C12()
    {
        MyDebug("En verdad he hecho bien en ir a ver mi novia, el proyecto puede esperar un rato, tambien tengo que cuidar mi vida personal");
        MyDebug("*Me pongo en camino*");
        C18(0);
    }
    void C13()
    {
        MyDebug("Mira ahí está la pastelería, uf encima no hay nada de cola como siempre hay, voy a meterme a ver que hay para comprarla");
        MyDebug("*Entro en la pastelería*");
        C14(0);
    }
    void C14(int x)
    {
        D5 = true;

        if (x == 0)
        {
            MyDebug("Ostias este pastel especial de la casa tiene una pintaza que te cagas, tengo que pillarlo si o si, encima es el sabor favorito de mi novia");
            MyDebug("*Pago el pedazo de pastel*");
            MyDebug("Bueno ahora para el curro que ya es hora de darle al working un rato");
            MyDebug("Aun que no se que hacer con el pastel seguro que si lo subo a la oficina" +
                " y lo guardo en la nevera alguien lo ve y me pide un trozo, pero si lo dejo aquí en el coche a lo mejor se pone malo");
            MyDebug("Que hago? 1.Guardar el pastel en la oficina 2.Guardarlo en el coche");
        }
        else if (x == 1)
        {
            MyDebug("Na me lo subo y esperemos que nadie lo vea y le apetezca");
            MyDebug("*Subo al curro con el pastel*");
            D5 = false;
            C22();
        }
        else if (x == 2)
        {
            MyDebug("Uf lo voy a dejar mejor en el coche que estos son unos glotones y me van a pedir y luego no va a quedar para mi novia");
            D5 = false;
            C26();
        }
    }
    void C15(int x)
    {
        D6 = true;

        if (x == 0)
        {
            MyDebug("En verdad este proyecto me está gustando bastante creo que si hoy le doy duro podría tener una versíon mas o menos decente," +
                " aun que con un poco más de tiempo podría revolucionar la industria");
            MyDebug("*Empiezo a trabajar bastante en el proyecto y tras bastantes horas despues");
            MyDebug("Buah esto ya casi casi, un momento me llama mi jefe por skype a ver que quiere a estas horas el pesado");
            MyDebug("-Jefe: Tú, como va el proyecto?");
            MyDebug("-Yo: Bueno pues casi casi terminado una versión bastante decente aun que con una o dos semanas más va a estar perfecto y entrará en plazo para testeos");
            MyDebug("-Jefe: Imposible lo necesito para mañana, me avisaron hace una semana que se adelantaba el plazo, así que no pares hasta que lo acabes si no esás despedido *Cuelga*");
            MyDebug("Como? Pero que coño? Este tio es y siempre ha sido un gilipollas que hago ahora? Me pongo a hacerlo o que le den por culo yono merezco este trato");
            MyDebug("Que hacer? 1.Trabajar hasta quelo termine 2.Desistir y ver que pasa?");
        }
        else if (x == 1)
        {
            MyDebug("Na vamos a darle duro, soy una maquina creo que puedo acabarlo perfectamente este noche si le doy duro, quiero ser participe de este proyecto");
            MyDebug("Aun que creo que este hijop***lo va a presentar como suyo, por si acaso le voy a poner detalles para que se note que es mi trabajo");
            D6 = false;
            C21();
        }
        else if (x == 2)
        {
            MyDebug("Mira paso, yo no me merzco esto este tio me ha hecho la vida imposible desde que entré en la empresa y solo me ha estado puteando");
            D6 = false;
            C25();
        }
    }
    void C16(int x)
    {
        D7 = true;

        if (x == 0)
        {
            MyDebug("-Buenos días, mire vengo a mirar este boleto de loteria a ver si hay suerte y me toca algo y me vuelvo rico jajajaj");
            MyDebug("-Dependiente: Buenas hijo, claro que si hombre dame el boleto");
            MyDebug("-Toma");
            MyDebug("*Le das el boleto al dependiente y lo comprueba*");
            MyDebug("-Dependiente: Chico...");
            MyDebug("*El dependiente se queda con una cara de asombro increible*");
            MyDebug("-Dime dime, y esa cara??");
            MyDebug("-Dependiente: Este boleto estaba premiado, encima con un premio increible");
            MyDebug("-Que dices enserio?");
            MyDebug("-Dependiente: Si si, hijo mio acabas de ganar *** millones de euros");
            MyDebug("-Cooooooomo?");
            MyDebug("*Te pones a saltar de la emocion, junto al dependiente*");
            MyDebug("-Y ahora que hago???");
            MyDebug("-Dependiente: Pues depues de cobrarlo, lo que quieras por que tienes la vida resulta, era un premio especial de una vez en la vida!!");
            MyDebug("-Suuuuuuuu, por fin gano algoooo");
            MyDebug("*Sales corriendo del establecimiento celebrandolo*");
            MyDebug("Y ahora que? Que hago con todo este dinerazo? En verdad es demasiado para mi en toda esta vida");
            MyDebug("Debería pensar que hacer con tanto dinero, bueno puedo ir a celebrarlo y luego ya pienso en ello");
            MyDebug("Que debería hacer? 1.Irme a casa a pensar sobre el dinero 2.Celebrarlo por todo lo alto");
        }
        else if (x == 1)
        {
            MyDebug("Bueno venga, voy a hacer algo sensato por una vez en mi vida, me voy a casa le tengo que dar la importancia necesaria a esto");
            MyDebug("*Te vas a casa*");
            D7 = false;
            C23();
        }
        else if (x == 2)
        {
            MyDebug("Que coño, vamos a celebrarlooo, dale Paco a celebrar!!!!!");
            MyDebug("*Te vas a celebrarlo por todo lo alto*");
            D7 = false;
            C27();
        }
    }
    void C17(int x)
    {
        D8 = true;

        if (x == 0)
        {
            MyDebug("*Llegamos a casa*");
            MyDebug("-Vale habla y date prisa que si no voy a llegar tarde al curro");
            MyDebug("-HR: A ver vengo de 80 años en el futuro y tengo advertirte por que si no te van a ocurrir desgracias tras desgracias, tanto a ti como a mama osea tu futura mujer");
            MyDebug("-Pero como se que todo lo que me estas contando es verdad y no me estas contando un cuento, es que como quieres que me crea que eres del futuro?");
            MyDebug("-HR: Uf vale ahí tienes toda la razón, pues mira justamente hoy es el cumpleaños de tu actual novia, además estas trabajando en un proyecto que te gusta mucho y crees que revolucionara tu industria," +
                "tu madre te llamó ayer para contarte que en unos meses  se iban a vivir a la casa de la playa por si te querías quedar su casa para vivir junto con tu actual novia, y te puedo seguir diciendo detalles");
            MyDebug("-QUE? como sabes eso? Todavía no le había contado a nadie lo de la casa, además lo del proyecto es secreto que mucha gente en la empresa ni lo saben");
            MyDebug("-HR: Por que vengo del futuro te lo he dicho, que soy tu hijo");
            MyDebug("-Y por que has repetido muchas veces lo de 'actual novia', no es tu madre?");
            MyDebug("-HR: Que va y menos mal que no la verdad menuda hija de puta");
            MyDebug("-Por?");
            MyDebug("-HR: Bueno primero espera que te cuento lo importante y luego ya vamos con los detalles");
            MyDebug("-Bueno venga vale cuentame");
            MyDebug("-HR: Hoy es el día que todo se te va a la mierda, según llames a Paco te dirá que ha ido a ver a una vidente y que entre muchas cosas le ha dicho que hoy tendrá la mayor suerte de su vida," +
                "ademas de que le habrá dado unos supuestos numeros ganadores de la lotería de hoy y como buen amigo los quiere compartir contigo");
            MyDebug("-Coño que grande el Paco, pero entonces eso es la ostia voy a ser millonario no?");
            MyDebug("-HR: Ahí reside el problema, este bucle se ha repetido inumerables veces dado que aun que muchas variantes han intentado impedirtelo siempre dices 'Na yo puedo evitarlo' y no puedes." +
                "En cuanto sepas el numero vas a ir a comprar un decimo y cuando ganes, que lo harás, pues ahí ya hay muchas posibilidades que te pongas a celebrarlo, que lo compartas o cualquier cosa y empezará todo lo malo");
            MyDebug("-Malo a que te refieres?");
            MyDebug("-HR: Pues como te he dicho hay varias posibilidades, o que te intenten robar a lo que te resistiras y entonces acabas apuñalado lo que te provocará un estado fisico deporable," +
                " o que según lo ganes empieces a ver la vida de una manera frivola y llena de interesados y los que eran tus allegados se empezaran a interesarse mas por ti debido a tu patrimonio, u otras series de posibilidades." +
                "Lo que pasa es que todas desembocan en el mismo punto, en el que coges una fuerte depresión te aislas entonces la gente empieza a dejarte abandonado por que no te entiende, tu novia te deja además de que te está poniendo los cuernos," +
                "y al resto de personas que les importas de verdad las alejas, pierdes ese proyecto que tanto quieres y entonces te quedas solo cuesta abajo y sin frenos siendo tu vida una mierda. Lo unico bueno es que conoceras a mi madre que será el amor de tu vida y eso te sacará de ese pozo," +
                "pero siempre estrás marcado por este día.");
            MyDebug("-Ostias, na pero puedo evitarlo");
            MyDebug("-HR: Lo ves, no no puedes");
            MyDebug("*Mensaje de Paco Mermela: Tú vente a mi casa te tengo una ofertaza*");
            MyDebug("-HR: Por favor no vayas");
            MyDebug("Que debería hacer? 1.No ir 2.Intentar ir");
        }
        else if (x == 1)
        {
            MyDebug("-Vale vale, no iré tranquilo");
            MyDebug("-HR: bien gracias, la verdad es la primera vez en la historia de este bucle temporal que me haces caso papá");
            MyDebug("-Cuantas veces ha ocurrido este bucle?");
            MyDebug("-HR: Demasiadas, siempre acabas cayendo en la avaricia y el prepotismo");
            D8 = false;
            C19();
        }
        else if (x == 2)
        {
            MyDebug("-Lo siento es una oportunidad única");
            MyDebug("-HR: No por favor no vayas, no puedo permitirlo");
            MyDebug("*Me bloquea el paso*");
            MyDebug("Que debería hacer? 1.No ir 2.Intentar ir");
        }

    }
    void C18(int x)
    {
        D9 = true;

        if (x == 0)
        {
            MyDebug("Vale ya estoy casi donde mi novia, yo creo que voy con tiempo de sobra para estar un rato con ella y luego ir al trabajo y no llegar muy muy tarde");
            MyDebug("*Llego a la casa de mi novia*");
            MyDebug("-Hola gorda, muchas felicidades mi amor *besos*");
            MyDebug("*Tras un buen rato juntos*");
            MyDebug("-Bueno amor, me tengo que ir ya que si no, no llego al curro");
            MyDebug("-Novia: Venga mi amor nos vemos luego para celebrar con mis padres mi cumple");
            MyDebug("-Perfe, por cierto tus padres te han comprado la tarta? o prefieres que vaya a tu pastelería favorita?");
            MyDebug("-Novia: Creo que no han comprado nada todavía");
            MyDebug("-Vale pues si eso ahora me acerco");
            MyDebug("*Veo el boleto de lotería que compré el otro día*");
            MyDebug("-Ostias debería ir a ver si me ha tocado algo");
            MyDebug("*Derrepente sueno un golpe proveniente de la habitación*");
            MyDebug("-Que ha sido eso?");
            MyDebug("-Novia: Nada nada seguro que se habrá caido algo");
            MyDebug("Que hacer? 1.Ir a revisar boleto 2.Inspeccionar el ruido 3.Ir a pastelería");
        }
        else if (x == 1)
        {
            MyDebug("Bueno voy a pasarme a mirar el boleto que hay uno justo al lado de mi oficina, chao");
            C20();
        }
        else if (x == 2)
        {
            MyDebug("-Voy a ver que ha sido ese ruido");
            MyDebug("-Novia: Que no hace falta amor seguro que es una tontería");
            MyDebug("-Bueno si se te ha caído algo te ayudo rapido a colocarlo");
            MyDebug("*Voy hacia la habitación*");
            C24();
        }
        else if (x == 3)
        {
            MyDebug("Bueno voy a pasarme por la pastelería antes de ir el curro amor chao");
            C28();
        }
    }
    void C19()
    {
        MyDebug("*Salen de casa*");
        MyDebug("-Bueno y ahora que?");
        MyDebug("-HR: Pues a esperar que pase este dia y todo habrá sido un exito");
        MyDebug("-Pues vamos a dar un paseo a ver que se nos ocurre hacer");
        MyDebug("*Fueron a dar un paseo mientras le contaba pinceladas del futuro*");
        C29();
    }
    void C20()
    {
        MyDebug("Va a ver si me toca algo");
        MyDebug("*Te vas a la oficina de loteria al lado de tu curro*");
        C5();
    }
    void C21()
    {
        MyDebug("Va va vamos a darle duro!");
        MyDebug("*Te pones a currar como un desgraciado y tras mucho tiempo y sin descansar lo terminas*");
        MyDebug("Buah lo he terminado, no me lo creo ni yo");
        MyDebug("Además los toques para que no me roben el codigo han quedado perfectos que alguien que minimamente se lo mire se va a dar cuenta");
        MyDebug("-Jefe: Tú, ya lo has terminado? Que te veo parado");
        MyDebug("-Si señor");
        MyDebug("-Jefe: Perfecto, justo a tiempo que la junta directiva está al caer y se lo tengo que presentar");
        MyDebug("*De repente aparece la junta directiva*");
        MyDebug("-Jefe: Buenas buenas, pasen a mi despacho");
        MyDebug("*Se van a su despacho y comienzan una larga reunion*");
        MyDebug("En verdad llevan bastante tiempo reunidos que estará pasando");
        MyDebug("*Se empiezan a oir gritos*");
        MyDebug("Que coño?");
        MyDebug("*Tras un rato sale tu jefe con sus cosas*");
        MyDebug("-Jefe: Tú, enano un día de estos te vas a enterar y me las pagarás");
        MyDebug("-Que ha pasado?");
        MyDebug("-Exjefe: Que ha pasado? Que no se que habrás hecho pero al leer tu codigo han entendido que no era mío y me han pillado intentando hacerlo pasar por mi trabajo, te mato!");
        MyDebug("-Eso le pasa por usar su puesto y no valorar a sus empleados");
        MyDebug("*Seguridad expulsa al pive del edificio*");
        MyDebug("Puff no me creo ni yo que eso haya funcionado por fin");
        C30();
    }
    void C22()
    {
        MyDebug("Vale vale ahora donde lo guardo, creo recordar que al lado de los despachos de la junta directiva en su sala descanso, había una nevera que solo usa el dueño");
        MyDebug("*Vas hacia esa sala y entras*");
        MyDebug("Que coño?");
        MyDebug("*De repente hay una multitud de personas celebrando un cumpleaños*");
        MyDebug("-Junta: Perdona, ahora mismo estamos celebrando el cumpleaños del dueño de la empresa vuelve luego");
        MyDebug("-Hay perdon perdon");
        MyDebug("-Dueño: Espera espera y eso que llevas ahí?");
        MyDebug("-Esto, eh es un pastel de cumpleaños");
        MyDebug("-Dueño: Que? Es para mi? Uf es mi favorito");
        MyDebug("*Momento mentira is coming*");
        MyDebug("-Emmm si claro, es que escuche el otro día que hoy era su cumple y quería hacerle un detalle que usted siempre nos a tratado bien");
        MyDebug("-Dueño: En serio? Joder que empleados tan geniales tengo, pues pasa hijo y quedate con nosotros un rato");
        MyDebug("-Si señor");
        MyDebug("*Tras un rato de celebración*");
        MyDebug("-Bueno muchas por dejar que me quede con ustedes un rato, me vuelvo a mi puesto a seguir con el proyecto");
        MyDebug("-Junta: Espera espera");
        C30();
    }
    void C23()
    {
        MyDebug("*Llegas a casa*");
        MyDebug("Buah ahora con todo este dinero que hago? En verdad me merezco todo este dinero? La verdad no lo sé, hay mucha gente que lo necesita mas que yo pero yo también me merezco vivir tranquilamente");
        MyDebug("Es que realmente ya no necesito tener que comer mierda con mi jefe todos los días, que si que el curro a veces me gusta pero ultimamente solo estoy agusto por el proyecto nuevo" +
            "y en verdad ese proyecto lo podría hacer perfectamente por mi cuenta con todo este dinero");
        MyDebug("Puff no sé que hacer, de verdad estoy bien viviendo esta vida?");
        MyDebug("*Te pones a reflexionar sobre tu vida y lo que podrias hacer con ella*");
        C31();
    }
    void C24()
    {
        MyDebug("*Entro en la habitación de donde provenía el ruido*");
        MyDebug("-Umm aparentemente no hay nada caido, ni roto, que raro. Hola? Hay alguien ahí?");
        MyDebug("-Novia: Pero como va a haber alguien aquí? Estas bobo?");
        MyDebug("-Que si, que yo he oido un golpe fuerte");
        MyDebug("*Empiezo a buscar en le habitación y me encuentro un calzoncillo*");
        MyDebug("-De quien coño es este calzoncillo?");
        MyDebug("-Novia: Amor te lo puedo explicar");
        MyDebug("*Sale del armario un pavo*");
        MyDebug("-Que coño está pasando aquí? ENSERIO? Me voy");
        MyDebug("-Novia: No cariño espera, escuchame");
        MyDebug("-No quiero hablar contigo ahora mismo");
        MyDebug("*Me voy dando un portazo");
        C31();
    }
    void C25()
    {
        MyDebug("No quiero hacer ya este proyecto, mira que tenía una ilusión que te cagas pero yo así no pienso trabajar");
        MyDebug("Me voy a ir a casa y ya mañana dimito, por que no puedo más");
        MyDebug("*Te vas a casa a pensar*");
        C31();
    }
    void C26()
    {
        MyDebug("*Te vas a currar dejando el pastel en el coche*");
        MyDebug("Vale por fin terminé de currar, ahora a volver a casa a disfrutar del pastelito");
        MyDebug("*Te vas a casa con la chorba y empezais a comeros el pastel*");
        MyDebug("-Esta rico no? Lo he pillado esta mañana en tu pastelería favorita");
        MyDebug("-Novia: Pero lo habrás tenido en frío todo el día no? Que este pastel lleva un ingrediente que como deje de recibir frío mas de x tiempo y luego te lo comas es muy dañino para el estomago");
        MyDebug("-Ehhh pues lo dejé en el coche la verdad, y ahora que lo dices si que me estoy empezando a encontar mal");
        MyDebug("*Te vas corriendo al baño y empiezas a vomitar*");
        MyDebug("En que momento no lo subí a la oficina");
        MyDebug("-Novia: Cariño estas bien?");
        MyDebug("-Si si, solo son vo...");
        MyDebug("*Te desmayas y te das con la cabeza en el vater y te haces una brecha que te desmayas*");
        MyDebug("-Novia: Cariño cariñooo, ostias tengo que llamar a una ambulancia hay mucha sangre");
        MyDebug("*Llama a la ambulancia*");
        C32();
    }
    void C27()
    {
        MyDebug("*Entras a un bar*");
        MyDebug("GENTEEE, QUE HE GANADO LA LOTERIA! A ESTA RONDA INVITO YO");
        MyDebug("*Aplausos y ovaciones de la gente*");
        MyDebug("Buah, esto el comienzo de una mejor vida para mi, de aquí para arriba voy a poder hacer todo lo que siempre quise y nadie ma lo va a impedir");
        MyDebug("POR EL DINERO DE LA LOTERIA!");
        MyDebug("*Te pasas un buen rato bebiendo y celebrandolo por todo lo alto*");
        MyDebug("Madre mia la que llevo encima, creo que me debería ir ya");
        MyDebug("*Sales del bar y hay tres tipos esperandote en la salida*");
        MyDebug("-T1: Que pasa tio, celebrando algo?");
        MyDebug("-Joder y tanto, ahora soy rico! *hipo de borracho*");
        MyDebug("-T2: Ah si? Pues nos vas a dar todo ese dinero no?");
        MyDebug("-Pero que dices tú");
        MyDebug("-T3: Si creo que si nos lo vas a dar, si sabes lo que te conviene");
        MyDebug("*Saca un cuchillo*");
        MyDebug("-Ni de coñaaa chavaaaal");
        MyDebug("*Empiezan forcejeos que desencadenan en una paliza que te dan*");
        MyDebug("-Me podreis dar una paliza pero el dinero nunca os lo daré");
        MyDebug("-T3: Bueno tú te lo has buscado");
        MyDebug("*Te apuñala y se van corriendo*");
        MyDebug("-Aaaaaaaahhhhh *Gritos de dolor*");
        MyDebug("-Que alguien llame a una ambulanciaaaaaa");
        MyDebug("*Por suerte pasa justo una persona por ahí y llama a la ambulancia*");
        C32();
    }
    void C28()
    {
        MyDebug("Vale vale, por el cumple de mi churri se merece todo y más");
        MyDebug("Creo que voy a ir a esa pastelería que tenía tantas ganas de probar ella");
        MyDebug("*Te vas hacia la pastelería");
        C13();
    }

    //Final secreto
    void C29()
    {
        MyDebug("-HR: Y así es como conseguí la maquina del tiempo");
        MyDebug("-Joder que buena historia la verdad, no esperaba menos de mi hijo jajaja");
        MyDebug("*Aparece derrepente por la calle Paco*");
        MyDebug("-Ostias Paco");
        MyDebug("-HR: Padre no!");
        MyDebug("-Ehhhhh... Con lo que me has contado estoy seguro que puedo con la situación");
        MyDebug("-HR: Nooooo");
        MyDebug("*Sales corriendo a ver Paco*");
        MyDebug("*Tu hijo te da un golpe en una parte especifica de la cabeza y te desmayas");
        MyDebug("-HR: Lo siento papa es por tu bien, DULCES SUEÑOS");
        MyDebug("*Quedas noqueado*");
        MyDebug("***********************");
        MyDebug("*********FIN?**********");
        MyDebug("***********************");
        MyDebug("*Te despiertas*");
        C1(0);
    }

    //Final bueno
    void C30()
    {
        
        MyDebug("-Junta: Venga para aquí por favor");
        MyDebug("-Dueño: Bueno, hemos tomado una decisión la junta y yo, y creemos que mereces más en esta empresa y por eso te vamos a ascender a jefe," +
            " siempre eres amable, buen compañero, trabajas muy bien incluso cuando te ha estado puteando tu antiguo jefe");
        MyDebug("-Enserio?? Esto no me lo creo");
        MyDebug("-Junta: Si, a partir de mañana usted es jefe y pasará a dirigir a todos sus compañeros, cobrará más obviamente y solo estará bajo nosotros");
        MyDebug("-Suuuuuuuuu");
        MyDebug("-Dueño: Enhorabuena");
        MyDebug("-Todo el esfuerzo hasta ahora ha tenido recompensa");
        MyDebug("**FIN**");
    }

    //Final malo?¿ 
    void C31()
    {
        MyDebug("De verdad me merezco esto? Realmente soy feliz con esta mierda?");
        MyDebug("No se que hacer ahora mismo, mandar todo a la mierda e irme por un timepo de todo me sentaría de lujo, para ver todo con perspectiva");
        MyDebug("Mi madre simpre ha sido muy sensata, quizas debería preguntarla para que me aconsejase");
        MyDebug("*Una larga llamada con mi madre después*");
        MyDebug("Bueno pues decidido, es momento de cambios en mi vida, me voy de esta ciudad por un tiempo");
        MyDebug("**FIN**");
    }

    //Final de muerte
    void C32()
    {
        MyDebug("*Ya en la ambulancia*");
        MyDebug("-Creo que hasta aquí ha llegado mi vida, ha sido una buena vida la pasé chido ahora es momento de irse al otro barrio");
        MyDebug("-Enf: Señor todavía se puede salvar");
        MyDebug("-Calla hombre que era una despedida epica, bueno alla vamos");
        MyDebug("*Te desmayas*");
        MyDebug("-Enf: Este tio es bobo solo se ha desmayado, bueno vamos a darnos prisa en atenderlos que al final tendrá razon el tio");
        MyDebug("**FIN**");
    }

    //Funcion para el Degug.log
    void MyDebug(string mensaje)
    {
        Debug.Log(mensaje);
    }
}