<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="AFFICHER phrase" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2para="" F2defaut="" F2lignes="" F2etat="inactif"/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param arrondiAuto="vrai" epaisseurPoint="2" epaisseurLigne="2" nbDecimales="8" totalBoucles="5000000" totalAffichages="1000" maxBoucle="500000"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="i EST_DU_TYPE NOMBRE" code="1#NOMBRE#i"/>
        <item algoitem="X EST_DU_TYPE NOMBRE" code="1#NOMBRE#X"/>
        <item algoitem="Xmax EST_DU_TYPE NOMBRE" code="1#NOMBRE#Xmax"/>
        <item algoitem="phrase EST_DU_TYPE CHAINE" code="1#CHAINE#phrase"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="AFFICHER &quot; Vous allez devoir rentrer 6 nombres &quot;" code="4# Vous allez devoir rentrer 6 nombres #1"/>
        <item algoitem="POUR i ALLANT_DE 1 A 6" code="12#i#1#6">
            <item algoitem="DEBUT_POUR" code="13#debutpour"/>
            <item algoitem="phrase PREND_LA_VALEUR &quot; veuillez rentrer la valeur du nombre numéro &quot; + i" code="5#phrase#&quot; veuillez rentrer la valeur du nombre numéro &quot; + i#pasliste"/>
            <item algoitem="AFFICHER phrase" code="3#phrase#1#pasliste"/>
            <item algoitem="LIRE X" code="2#X#pasliste"/>
            <item algoitem="SI (X > Xmax) ALORS" code="6#X > Xmax">
                <item algoitem="DEBUT_SI" code="7#debutsi"/>
                <item algoitem="Xmax PREND_LA_VALEUR X" code="5#Xmax#X#pasliste"/>
                <item algoitem="FIN_SI" code="8#finsi"/>
            </item>
            <item algoitem="FIN_POUR" code="14#finpour"/>
        </item>
        <item algoitem="phrase PREND_LA_VALEUR Xmax + &quot; est le plus grand nombre entré &quot;" code="5#phrase#Xmax + &quot; est le plus grand nombre entré &quot;#pasliste"/>
        <item algoitem="AFFICHER phrase" code="3#phrase#1#pasliste"/>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
