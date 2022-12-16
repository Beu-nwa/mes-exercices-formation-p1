<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description texte="" courant="AFFICHER reponse"/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2lignes="" F2para="" F2etat="inactif" F2defaut=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param epaisseurPoint="2" nbDecimales="8" totalAffichages="1000" totalBoucles="5000000" maxBoucle="500000" epaisseurLigne="2" arrondiAuto="vrai"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="x EST_DU_TYPE NOMBRE" code="1#NOMBRE#x"/>
        <item algoitem="reponse EST_DU_TYPE CHAINE" code="1#CHAINE#reponse"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="LIRE x" code="2#x#pasliste"/>
        <item algoitem="SI (x % 3 != 0) ALORS" code="6#x % 3 != 0">
            <item algoitem="DEBUT_SI" code="7#debutsi"/>
            <item algoitem="reponse PREND_LA_VALEUR &quot; la valeur entrée &quot; + x + &quot; n'est pas divisible par 3 &quot;" code="5#reponse#&quot; la valeur entrée &quot; + x + &quot; n'est pas divisible par 3 &quot;#pasliste"/>
            <item algoitem="FIN_SI" code="8#finsi"/>
            <item algoitem="SINON" code="9#sinon">
                <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                <item algoitem="reponse PREND_LA_VALEUR &quot; la valeur entrée &quot; + x + &quot; est divisible par 3 &quot;" code="5#reponse#&quot; la valeur entrée &quot; + x + &quot; est divisible par 3 &quot;#pasliste"/>
                <item algoitem="FIN_SINON" code="11#finsinon"/>
            </item>
        </item>
        <item algoitem="AFFICHER reponse" code="3#reponse#1#pasliste"/>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
