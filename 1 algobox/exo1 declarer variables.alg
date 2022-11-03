<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description texte="" courant="AFFICHER C"/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2etat="inactif" F2defaut="" F2lignes="" F2para=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param epaisseurPoint="2" arrondiAuto="vrai" nbDecimales="8" totalBoucles="5000000" totalAffichages="1000" epaisseurLigne="2" maxBoucle="500000"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="A EST_DU_TYPE NOMBRE" code="1#NOMBRE#A"/>
        <item algoitem="B EST_DU_TYPE NOMBRE" code="1#NOMBRE#B"/>
        <item algoitem="C EST_DU_TYPE NOMBRE" code="1#NOMBRE#C"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="A PREND_LA_VALEUR 3" code="5#A#3#pasliste"/>
        <item algoitem="B PREND_LA_VALEUR 7" code="5#B#7#pasliste"/>
        <item algoitem="AFFICHER &quot;lES PREMIERES VARIABLES SONT : &quot;" code="4#lES PREMIERES VARIABLES SONT : #1"/>
        <item algoitem="AFFICHER A" code="3#A#1#pasliste"/>
        <item algoitem="AFFICHER B" code="3#B#1#pasliste"/>
        <item algoitem="A PREND_LA_VALEUR B" code="5#A#B#pasliste"/>
        <item algoitem="AFFICHER &quot;la nouvelle valeur de A est : &quot;" code="4#la nouvelle valeur de A est : #0"/>
        <item algoitem="AFFICHER A" code="3#A#1#pasliste"/>
        <item algoitem="B PREND_LA_VALEUR A+5" code="5#B#A+5#pasliste"/>
        <item algoitem="AFFICHER &quot;la nouvelle valeur de B est : &quot;" code="4#la nouvelle valeur de B est : #0"/>
        <item algoitem="AFFICHER B" code="3#B#1#pasliste"/>
        <item algoitem="C PREND_LA_VALEUR A+B" code="5#C#A+B#pasliste"/>
        <item algoitem="AFFICHER &quot;la nouvelle valeur de C est : &quot;" code="4#la nouvelle valeur de C est : #0"/>
        <item algoitem="AFFICHER C" code="3#C#1#pasliste"/>
        <item algoitem="C PREND_LA_VALEUR B-A" code="5#C#B-A#pasliste"/>
        <item algoitem="AFFICHER &quot;la nouvelle valeur de C est : &quot;" code="4#la nouvelle valeur de C est : #0"/>
        <item algoitem="AFFICHER C" code="3#C#1#pasliste"/>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
