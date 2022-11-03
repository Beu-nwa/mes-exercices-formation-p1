<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="FIN_SINON" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2lignes="" F2defaut="" F2etat="inactif" F2para=""/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param epaisseurLigne="2" maxBoucle="500000" totalAffichages="1000" totalBoucles="5000000" epaisseurPoint="2" arrondiAuto="vrai" nbDecimales="8"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="AB EST_DU_TYPE NOMBRE" code="1#NOMBRE#AB"/>
        <item algoitem="BC EST_DU_TYPE NOMBRE" code="1#NOMBRE#BC"/>
        <item algoitem="CA EST_DU_TYPE NOMBRE" code="1#NOMBRE#CA"/>
        <item algoitem="reponse EST_DU_TYPE CHAINE" code="1#CHAINE#reponse"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="AFFICHER reponse" code="3#reponse#1#pasliste"/>
        <item algoitem="AFFICHER &quot; Renseigner la longueur de côté AB du triangle ABC &quot;" code="4# Renseigner la longueur de côté AB du triangle ABC #1"/>
        <item algoitem="LIRE AB" code="2#AB#pasliste"/>
        <item algoitem="AFFICHER &quot; Renseigner la longueur de côté BC du triangle ABC &quot;" code="4# Renseigner la longueur de côté BC du triangle ABC #1"/>
        <item algoitem="LIRE BC" code="2#BC#pasliste"/>
        <item algoitem="AFFICHER &quot; Renseigner la longueur de côté CA du triangle ABC &quot;" code="4# Renseigner la longueur de côté CA du triangle ABC #1"/>
        <item algoitem="LIRE CA" code="2#CA#pasliste"/>
        <item algoitem="SI (AB == BC) ALORS" code="6#AB == BC">
            <item algoitem="DEBUT_SI" code="7#debutsi"/>
            <item algoitem="SI (AB == CA) ALORS" code="6#AB == CA">
                <item algoitem="DEBUT_SI" code="7#debutsi"/>
                <item algoitem="reponse PREND_LA_VALEUR &quot; Le triangle est équilatéral &quot;" code="5#reponse#&quot; Le triangle est équilatéral &quot;#pasliste"/>
                <item algoitem="FIN_SI" code="8#finsi"/>
                <item algoitem="SINON" code="9#sinon">
                    <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                    <item algoitem="reponse PREND_LA_VALEUR &quot; Le triangle est isocèle en B&quot;" code="5#reponse#&quot; Le triangle est isocèle en B&quot;#pasliste"/>
                    <item algoitem="FIN_SINON" code="11#finsinon"/>
                </item>
            </item>
            <item algoitem="FIN_SI" code="8#finsi"/>
            <item algoitem="SINON" code="9#sinon">
                <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                <item algoitem="FIN_SINON" code="11#finsinon"/>
            </item>
        </item>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
