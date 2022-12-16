<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="AFFICHER B" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctcode="" fctetat="inactif"/>
    <F2 F2defaut="" F2para="" F2lignes="" F2etat="inactif"/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param epaisseurPoint="2" totalBoucles="5000000" arrondiAuto="vrai" totalAffichages="1000" nbDecimales="8" epaisseurLigne="2" maxBoucle="500000"/>
    <item code="200#declarationfonctions" algoitem="FONCTIONS_UTILISEES"/>
    <item code="100#declarationsvariables" algoitem="VARIABLES">
        <item code="1#NOMBRE#A" algoitem="A EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#B" algoitem="B EST_DU_TYPE NOMBRE"/>
    </item>
    <item code="101#debutalgo" algoitem="DEBUT_ALGORITHME">
        <item code="4#entrez un nombre : #1" algoitem="AFFICHER &quot;entrez un nombre : &quot;"/>
        <item code="2#A#pasliste" algoitem="LIRE A"/>
        <item code="5#B#2*A#pasliste" algoitem="B PREND_LA_VALEUR 2*A"/>
        <item code="4#la valeur entrée est : #1" algoitem="AFFICHER &quot;la valeur entrée est : &quot;"/>
        <item code="3#A#1#pasliste" algoitem="AFFICHER A"/>
        <item code="4#le double de A est : #1" algoitem="AFFICHER &quot;le double de A est : &quot;"/>
        <item code="3#B#1#pasliste" algoitem="AFFICHER B"/>
    </item>
    <item code="102#finalgo" algoitem="FIN_ALGORITHME"/>
</Algo>
