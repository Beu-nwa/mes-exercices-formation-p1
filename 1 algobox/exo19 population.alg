<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description texte="" courant="AFFICHER phrase"/>
    <extension extnom="inactif"/>
    <fonction fctcode="" fctetat="inactif"/>
    <F2 F2defaut="" F2para="" F2lignes="" F2etat="inactif"/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param epaisseurLigne="2" epaisseurPoint="2" maxBoucle="500000" nbDecimales="8" arrondiAuto="vrai" totalBoucles="5000000" totalAffichages="1000"/>
    <item code="200#declarationfonctions" algoitem="FONCTIONS_UTILISEES"/>
    <item code="100#declarationsvariables" algoitem="VARIABLES">
        <item code="1#NOMBRE#t" algoitem="t EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#n" algoitem="n EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#p" algoitem="p EST_DU_TYPE NOMBRE"/>
        <item code="1#CHAINE#phrase" algoitem="phrase EST_DU_TYPE CHAINE"/>
    </item>
    <item code="101#debutalgo" algoitem="DEBUT_ALGORITHME">
        <item code="5#t#0.0089#pasliste" algoitem="t PREND_LA_VALEUR 0.0089"/>
        <item code="5#p#96809#pasliste" algoitem="p PREND_LA_VALEUR 96809"/>
        <item code="15#p &lt;= 120000" algoitem="TANT_QUE (p &lt;= 120000) FAIRE">
            <item code="16#debuttantque" algoitem="DEBUT_TANT_QUE"/>
            <item code="5#p#p*(1+t)#pasliste" algoitem="p PREND_LA_VALEUR p*(1+t)"/>
            <item code="5#n#n + 1#pasliste" algoitem="n PREND_LA_VALEUR n + 1"/>
            <item code="17#fintantque" algoitem="FIN_TANT_QUE"/>
        </item>
        <item code="5#phrase#&quot; Il faudra &quot; + n + &quot; années pour que la ville atteigne &quot; + round(p) + &quot;habitants. Cela arrivera en &quot; + (n+2015)#pasliste" algoitem="phrase PREND_LA_VALEUR &quot; Il faudra &quot; + n + &quot; années pour que la ville atteigne &quot; + round(p) + &quot;habitants. Cela arrivera en &quot; + (n+2015)"/>
        <item code="3#phrase#1#pasliste" algoitem="AFFICHER phrase"/>
    </item>
    <item code="102#finalgo" algoitem="FIN_ALGORITHME"/>
</Algo>
