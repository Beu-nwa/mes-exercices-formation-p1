<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description texte="" courant="FIN_POUR"/>
    <extension extnom="inactif"/>
    <fonction fctcode="" fctetat="inactif"/>
    <F2 F2para="" F2lignes="" F2defaut="" F2etat="inactif"/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param totalBoucles="5000000" epaisseurPoint="2" epaisseurLigne="2" nbDecimales="8" arrondiAuto="vrai" totalAffichages="1000" maxBoucle="500000"/>
    <item code="200#declarationfonctions" algoitem="FONCTIONS_UTILISEES"/>
    <item code="100#declarationsvariables" algoitem="VARIABLES">
        <item code="1#CHAINE#ligne" algoitem="ligne EST_DU_TYPE CHAINE"/>
        <item code="1#NOMBRE#x" algoitem="x EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#i" algoitem="i EST_DU_TYPE NOMBRE"/>
    </item>
    <item code="101#debutalgo" algoitem="DEBUT_ALGORITHME">
        <item code="4# Jusqu'à quel nombre voulez vous voir la suite ? #1" algoitem="AFFICHER &quot; Jusqu'à quel nombre voulez vous voir la suite ? &quot;"/>
        <item code="2#x#pasliste" algoitem="LIRE x"/>
        <item code="6#x&lt;0" algoitem="SI (x&lt;0) ALORS">
            <item code="7#debutsi" algoitem="DEBUT_SI"/>
            <item code="5#x#-x#pasliste" algoitem="x PREND_LA_VALEUR -x"/>
            <item code="8#finsi" algoitem="FIN_SI"/>
        </item>
        <item code="12#i#1#x" algoitem="POUR i ALLANT_DE 1 A x">
            <item code="13#debutpour" algoitem="DEBUT_POUR"/>
            <item code="5#ligne#ligne + i + &quot; &quot;#pasliste" algoitem="ligne PREND_LA_VALEUR ligne + i + &quot; &quot;"/>
            <item code="3#ligne#1#pasliste" algoitem="AFFICHER ligne"/>
            <item code="14#finpour" algoitem="FIN_POUR"/>
        </item>
    </item>
    <item code="102#finalgo" algoitem="FIN_ALGORITHME"/>
</Algo>
