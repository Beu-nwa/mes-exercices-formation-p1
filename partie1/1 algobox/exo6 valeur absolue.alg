<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="AFFICHER reponse" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2defaut="" F2para="" F2etat="inactif" F2lignes=""/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param epaisseurLigne="2" arrondiAuto="vrai" epaisseurPoint="2" maxBoucle="500000" totalBoucles="5000000" totalAffichages="1000" nbDecimales="8"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="x EST_DU_TYPE NOMBRE" code="1#NOMBRE#x"/>
        <item algoitem="va EST_DU_TYPE NOMBRE" code="1#NOMBRE#va"/>
        <item algoitem="reponse EST_DU_TYPE CHAINE" code="1#CHAINE#reponse"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="AFFICHER &quot;Donner un réel&quot;" code="4#Donner un réel#1"/>
        <item algoitem="LIRE x" code="2#x#pasliste"/>
        <item algoitem="SI (x &lt; 0) ALORS" code="6#x &lt; 0">
            <item algoitem="DEBUT_SI" code="7#debutsi"/>
            <item algoitem="va PREND_LA_VALEUR -x" code="5#va#-x#pasliste"/>
            <item algoitem="FIN_SI" code="8#finsi"/>
            <item algoitem="SINON" code="9#sinon">
                <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                <item algoitem="va PREND_LA_VALEUR x" code="5#va#x#pasliste"/>
                <item algoitem="FIN_SINON" code="11#finsinon"/>
            </item>
        </item>
        <item algoitem="reponse PREND_LA_VALEUR x + &quot; a pour valeur absolue &quot; + va" code="5#reponse#x + &quot; a pour valeur absolue &quot; + va#pasliste"/>
        <item algoitem="AFFICHER reponse" code="3#reponse#1#pasliste"/>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
