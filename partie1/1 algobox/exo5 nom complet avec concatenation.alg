<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="AFFICHER REPONSE" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctcode="" fctetat="inactif"/>
    <F2 F2defaut="" F2para="" F2lignes="" F2etat="inactif"/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param epaisseurPoint="2" totalBoucles="5000000" arrondiAuto="vrai" totalAffichages="1000" nbDecimales="8" epaisseurLigne="2" maxBoucle="500000"/>
    <item code="200#declarationfonctions" algoitem="FONCTIONS_UTILISEES"/>
    <item code="100#declarationsvariables" algoitem="VARIABLES">
        <item code="1#CHAINE#NOM" algoitem="NOM EST_DU_TYPE CHAINE"/>
        <item code="1#CHAINE#PRENOM" algoitem="PRENOM EST_DU_TYPE CHAINE"/>
        <item code="1#CHAINE#REPONSE" algoitem="REPONSE EST_DU_TYPE CHAINE"/>
    </item>
    <item code="101#debutalgo" algoitem="DEBUT_ALGORITHME">
        <item code="4#QUEL EST VOTRE NOM#0" algoitem="AFFICHER &quot;QUEL EST VOTRE NOM&quot;"/>
        <item code="2#NOM#pasliste" algoitem="LIRE NOM"/>
        <item code="4#QUEL EST VOTRE PRENOM#0" algoitem="AFFICHER &quot;QUEL EST VOTRE PRENOM&quot;"/>
        <item code="2#PRENOM#pasliste" algoitem="LIRE PRENOM"/>
        <item code="4#VOTRE PRENOM EST : #0" algoitem="AFFICHER &quot;VOTRE PRENOM EST : &quot;"/>
        <item code="3#PRENOM#1#pasliste" algoitem="AFFICHER PRENOM"/>
        <item code="4#VOTRE NOM EST : #0" algoitem="AFFICHER &quot;VOTRE NOM EST : &quot;"/>
        <item code="3#NOM#1#pasliste" algoitem="AFFICHER NOM"/>
        <item code="5#REPONSE#NOM + &quot; &quot; + PRENOM#pasliste" algoitem="REPONSE PREND_LA_VALEUR NOM + &quot; &quot; + PRENOM"/>
        <item code="4#Votre nom complet est : #0" algoitem="AFFICHER &quot;Votre nom complet est : &quot;"/>
        <item code="3#REPONSE#0#pasliste" algoitem="AFFICHER REPONSE"/>
    </item>
    <item code="102#finalgo" algoitem="FIN_ALGORITHME"/>
</Algo>
