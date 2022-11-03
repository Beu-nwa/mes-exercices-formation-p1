<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="FIN_POUR" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctcode="" fctetat="inactif"/>
    <F2 F2etat="inactif" F2para="" F2defaut="" F2lignes=""/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param maxBoucle="500000" totalAffichages="1000" totalBoucles="5000000" epaisseurLigne="2" nbDecimales="8" epaisseurPoint="2" arrondiAuto="vrai"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="x EST_DU_TYPE NOMBRE" code="1#NOMBRE#x"/>
        <item algoitem="n EST_DU_TYPE NOMBRE" code="1#NOMBRE#n"/>
        <item algoitem="nf EST_DU_TYPE NOMBRE" code="1#NOMBRE#nf"/>
        <item algoitem="resultat EST_DU_TYPE NOMBRE" code="1#NOMBRE#resultat"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="AFFICHER &quot; De quel nombre voulez vous voir la table de multiplication ? &quot;" code="4# De quel nombre voulez vous voir la table de multiplication ? #1"/>
        <item algoitem="LIRE x" code="2#x#pasliste"/>
        <item algoitem="AFFICHER &quot; Jusqu'à quel nombre voulez-vous le voir multiplié &quot;" code="4# Jusqu'à quel nombre voulez-vous le voir multiplié #1"/>
        <item algoitem="LIRE nf" code="2#nf#pasliste"/>
        <item algoitem="SI (nf&lt;0) ALORS" code="6#nf&lt;0">
            <item algoitem="DEBUT_SI" code="7#debutsi"/>
            <item algoitem="nf PREND_LA_VALEUR -nf" code="5#nf#-nf#pasliste"/>
            <item algoitem="FIN_SI" code="8#finsi"/>
        </item>
        <item algoitem="POUR n ALLANT_DE 0 A nf" code="12#n#0#nf">
            <item algoitem="DEBUT_POUR" code="13#debutpour"/>
            <item algoitem="resultat PREND_LA_VALEUR n*x" code="5#resultat#n*x#pasliste"/>
            <item algoitem="AFFICHER resultat" code="3#resultat#1#pasliste"/>
            <item algoitem="FIN_POUR" code="14#finpour"/>
        </item>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
