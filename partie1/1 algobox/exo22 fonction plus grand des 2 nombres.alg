<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description texte="" courant="AFFICHER reponse"/>
    <extension extnom="inactif"/>
    <fonction fctcode="" fctetat="inactif"/>
    <F2 F2etat="inactif" F2defaut="" F2lignes="" F2para=""/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param totalBoucles="5000000" maxBoucle="500000" epaisseurPoint="2" totalAffichages="1000" nbDecimales="8" arrondiAuto="vrai" epaisseurLigne="2"/>
    <item code="200#declarationfonctions" algoitem="FONCTIONS_UTILISEES">
        <item code="201#fctLePlusGrand#a,b" algoitem="FONCTION fctLePlusGrand(a,b)">
            <item code="202#declarationsvariablesfonction" algoitem="VARIABLES_FONCTION"/>
            <item code="203#debutfonction" algoitem="DEBUT_FONCTION"/>
            <item code="6#a>b" algoitem="SI (a>b) ALORS">
                <item code="7#debutsi" algoitem="DEBUT_SI"/>
                <item code="205#a" algoitem="RENVOYER a"/>
                <item code="8#finsi" algoitem="FIN_SI"/>
                <item code="9#sinon" algoitem="SINON">
                    <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                    <item code="205#b" algoitem="RENVOYER b"/>
                    <item code="11#finsinon" algoitem="FIN_SINON"/>
                </item>
            </item>
            <item code="204#finfonction" algoitem="FIN_FONCTION"/>
        </item>
    </item>
    <item code="100#declarationsvariables" algoitem="VARIABLES">
        <item code="1#CHAINE#reponse" algoitem="reponse EST_DU_TYPE CHAINE"/>
        <item code="1#NOMBRE#x1" algoitem="x1 EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#x2" algoitem="x2 EST_DU_TYPE NOMBRE"/>
    </item>
    <item code="101#debutalgo" algoitem="DEBUT_ALGORITHME">
        <item code="4# Rentrer 2 nombre afin de savoir lequel est le plus grand. #1" algoitem="AFFICHER &quot; Rentrer 2 nombre afin de savoir lequel est le plus grand. &quot;"/>
        <item code="2#x1#pasliste" algoitem="LIRE x1"/>
        <item code="2#x2#pasliste" algoitem="LIRE x2"/>
        <item code="5#reponse#&quot; entre &quot; + x1 + &quot; et &quot; + x2 + &quot;, le plus grand est : &quot; + fctLePlusGrand(x1,x2)#pasliste" algoitem="reponse PREND_LA_VALEUR &quot; entre &quot; + x1 + &quot; et &quot; + x2 + &quot;, le plus grand est : &quot; + fctLePlusGrand(x1,x2)"/>
        <item code="3#reponse#1#pasliste" algoitem="AFFICHER reponse"/>
    </item>
    <item code="102#finalgo" algoitem="FIN_ALGORITHME"/>
</Algo>
