<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="AFFICHER phrase2" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2lignes="" F2para="" F2etat="inactif" F2defaut=""/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param epaisseurLigne="2" maxBoucle="500000" totalAffichages="1000" epaisseurPoint="2" arrondiAuto="vrai" nbDecimales="8" totalBoucles="5000000"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="n EST_DU_TYPE NOMBRE" code="1#NOMBRE#n"/>
        <item algoitem="i EST_DU_TYPE NOMBRE" code="1#NOMBRE#i"/>
        <item algoitem="phrase EST_DU_TYPE CHAINE" code="1#CHAINE#phrase"/>
        <item algoitem="phrase2 EST_DU_TYPE CHAINE" code="1#CHAINE#phrase2"/>
        <item algoitem="monTableau EST_DU_TYPE LISTE" code="1#LISTE#monTableau"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="AFFICHER &quot; Combien de note voulez vous entrer&quot;" code="4# Combien de note voulez vous entrer#1"/>
        <item algoitem="LIRE n" code="2#n#pasliste"/>
        <item algoitem="POUR i ALLANT_DE 0 A (n-1)" code="12#i#0#(n-1)">
            <item algoitem="DEBUT_POUR" code="13#debutpour"/>
            <item algoitem="phrase PREND_LA_VALEUR &quot; entrez la note n° : &quot; + (i+1)" code="5#phrase#&quot; entrez la note n° : &quot; + (i+1)#pasliste"/>
            <item algoitem="AFFICHER phrase" code="3#phrase#1#pasliste"/>
            <item algoitem="LIRE monTableau[i]" code="2#monTableau#i"/>
            <item algoitem="phrase2 PREND_LA_VALEUR phrase2 + &quot; &quot; + monTableau[i]" code="5#phrase2#phrase2 + &quot; &quot; + monTableau[i]#pasliste"/>
            <item algoitem="FIN_POUR" code="14#finpour"/>
        </item>
        <item algoitem="AFFICHER phrase2" code="3#phrase2#1#pasliste"/>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
