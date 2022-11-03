<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="FIN_POUR" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2lignes="" F2etat="inactif" F2para="" F2defaut=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param epaisseurPoint="2" totalAffichages="1000" nbDecimales="8" arrondiAuto="vrai" totalBoucles="5000000" epaisseurLigne="2" maxBoucle="500000"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="x EST_DU_TYPE NOMBRE" code="1#NOMBRE#x"/>
        <item algoitem="n EST_DU_TYPE NOMBRE" code="1#NOMBRE#n"/>
        <item algoitem="i EST_DU_TYPE NOMBRE" code="1#NOMBRE#i"/>
        <item algoitem="resultat EST_DU_TYPE NOMBRE" code="1#NOMBRE#resultat"/>
        <item algoitem="phrase EST_DU_TYPE CHAINE" code="1#CHAINE#phrase"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="POUR i ALLANT_DE 1 A 10" code="12#i#1#10">
            <item algoitem="DEBUT_POUR" code="13#debutpour"/>
            <item algoitem="AFFICHER &quot; &quot;" code="4# #1"/>
            <item algoitem="x PREND_LA_VALEUR i" code="5#x#i#pasliste"/>
            <item algoitem="phrase PREND_LA_VALEUR &quot; Table de : &quot; + i" code="5#phrase#&quot; Table de : &quot; + i#pasliste"/>
            <item algoitem="AFFICHER phrase" code="3#phrase#1#pasliste"/>
            <item algoitem="POUR n ALLANT_DE 0 A 10" code="12#n#0#10">
                <item algoitem="DEBUT_POUR" code="13#debutpour"/>
                <item algoitem="phrase PREND_LA_VALEUR n + &quot; x &quot; + x + &quot; = &quot; + resultat" code="5#phrase#n + &quot; x &quot; + x + &quot; = &quot; + resultat#pasliste"/>
                <item algoitem="resultat PREND_LA_VALEUR n*x" code="5#resultat#n*x#pasliste"/>
                <item algoitem="AFFICHER phrase" code="3#phrase#1#pasliste"/>
                <item algoitem="FIN_POUR" code="14#finpour"/>
            </item>
            <item algoitem="FIN_POUR" code="14#finpour"/>
        </item>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
