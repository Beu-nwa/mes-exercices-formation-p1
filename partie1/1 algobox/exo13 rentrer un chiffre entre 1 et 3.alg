<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description texte="" courant="AFFICHER &quot; Bravo! Vous avez entré un nombre compris entre 1 et 3 ! &quot;"/>
    <extension extnom="inactif"/>
    <fonction fctcode="" fctetat="inactif"/>
    <F2 F2defaut="" F2lignes="" F2para="" F2etat="inactif"/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param epaisseurLigne="2" nbDecimales="8" totalBoucles="5000000" epaisseurPoint="2" totalAffichages="1000" maxBoucle="500000" arrondiAuto="vrai"/>
    <item code="200#declarationfonctions" algoitem="FONCTIONS_UTILISEES"/>
    <item code="100#declarationsvariables" algoitem="VARIABLES">
        <item code="1#NOMBRE#x" algoitem="x EST_DU_TYPE NOMBRE"/>
    </item>
    <item code="101#debutalgo" algoitem="DEBUT_ALGORITHME">
        <item code="4# Donner un nombre compris entre 1 et 3 #1" algoitem="AFFICHER &quot; Donner un nombre compris entre 1 et 3 &quot;"/>
        <item code="2#x#pasliste" algoitem="LIRE x"/>
        <item code="15#x&lt;1 OU x>3" algoitem="TANT_QUE (x&lt;1 OU x>3) FAIRE">
            <item code="16#debuttantque" algoitem="DEBUT_TANT_QUE"/>
            <item code="4# Le nombre entré n'est pas compris entre 1 et 3, réessayez ! #1" algoitem="AFFICHER &quot; Le nombre entré n'est pas compris entre 1 et 3, réessayez ! &quot;"/>
            <item code="2#x#pasliste" algoitem="LIRE x"/>
            <item code="17#fintantque" algoitem="FIN_TANT_QUE"/>
        </item>
        <item code="4# Bravo! Vous avez entré un nombre compris entre 1 et 3 ! #1" algoitem="AFFICHER &quot; Bravo! Vous avez entré un nombre compris entre 1 et 3 ! &quot;"/>
    </item>
    <item code="102#finalgo" algoitem="FIN_ALGORITHME"/>
</Algo>
