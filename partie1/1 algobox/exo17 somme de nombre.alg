<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="AFFICHER r" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctcode="" fctetat="inactif"/>
    <F2 F2para="" F2lignes="" F2etat="inactif" F2defaut=""/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param epaisseurPoint="2" arrondiAuto="vrai" totalAffichages="1000" maxBoucle="500000" totalBoucles="5000000" epaisseurLigne="2" nbDecimales="8"/>
    <item code="200#declarationfonctions" algoitem="FONCTIONS_UTILISEES"/>
    <item code="100#declarationsvariables" algoitem="VARIABLES">
        <item code="1#NOMBRE#x" algoitem="x EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#i" algoitem="i EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#r" algoitem="r EST_DU_TYPE NOMBRE"/>
        <item code="1#CHAINE#phrase" algoitem="phrase EST_DU_TYPE CHAINE"/>
    </item>
    <item code="101#debutalgo" algoitem="DEBUT_ALGORITHME">
        <item code="5#r#0#pasliste" algoitem="r PREND_LA_VALEUR 0"/>
        <item code="4# Jusqu'à quel nombre voulez-vous calculer la somme ? : Σ#1" algoitem="AFFICHER &quot; Jusqu'à quel nombre voulez-vous calculer la somme ? : Σ&quot;"/>
        <item code="2#x#pasliste" algoitem="LIRE x"/>
        <item code="6#x&lt;0" algoitem="SI (x&lt;0) ALORS">
            <item code="7#debutsi" algoitem="DEBUT_SI"/>
            <item code="5#x#-x#pasliste" algoitem="x PREND_LA_VALEUR -x"/>
            <item code="8#finsi" algoitem="FIN_SI"/>
        </item>
        <item code="5#phrase#&quot;Σ&quot; + x + &quot; = &quot;#pasliste" algoitem="phrase PREND_LA_VALEUR &quot;Σ&quot; + x + &quot; = &quot;"/>
        <item code="12#i#1#x" algoitem="POUR i ALLANT_DE 1 A x">
            <item code="13#debutpour" algoitem="DEBUT_POUR"/>
            <item code="6#i != 1" algoitem="SI (i != 1) ALORS">
                <item code="7#debutsi" algoitem="DEBUT_SI"/>
                <item code="5#phrase#phrase + &quot; + &quot;#pasliste" algoitem="phrase PREND_LA_VALEUR phrase + &quot; + &quot;"/>
                <item code="8#finsi" algoitem="FIN_SI"/>
            </item>
            <item code="5#r#r + i#pasliste" algoitem="r PREND_LA_VALEUR r + i"/>
            <item code="5#phrase#phrase + i#pasliste" algoitem="phrase PREND_LA_VALEUR phrase + i"/>
            <item code="14#finpour" algoitem="FIN_POUR"/>
        </item>
        <item code="3#phrase#0#pasliste" algoitem="AFFICHER phrase"/>
        <item code="4# = #0" algoitem="AFFICHER &quot; = &quot;"/>
        <item code="3#r#0#pasliste" algoitem="AFFICHER r"/>
    </item>
    <item code="102#finalgo" algoitem="FIN_ALGORITHME"/>
</Algo>
