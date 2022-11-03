<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="AFFICHER reponse" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2defaut="" F2etat="inactif" F2lignes="" F2para=""/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param totalBoucles="5000000" epaisseurLigne="2" maxBoucle="500000" totalAffichages="1000" epaisseurPoint="2" nbDecimales="8" arrondiAuto="vrai"/>
    <item code="200#declarationfonctions" algoitem="FONCTIONS_UTILISEES"/>
    <item code="100#declarationsvariables" algoitem="VARIABLES">
        <item code="1#NOMBRE#c" algoitem="c EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#t" algoitem="t EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#n" algoitem="n EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#Cn" algoitem="Cn EST_DU_TYPE NOMBRE"/>
        <item code="1#CHAINE#reponse" algoitem="reponse EST_DU_TYPE CHAINE"/>
    </item>
    <item code="101#debutalgo" algoitem="DEBUT_ALGORITHME">
        <item code="4# Quel est le montant du capital que vous voulez placer ? #1" algoitem="AFFICHER &quot; Quel est le montant du capital que vous voulez placer ? &quot;"/>
        <item code="2#c#pasliste" algoitem="LIRE c"/>
        <item code="4# Quel est le taux d'intérets correspondant (donner la valeur en %) ? #1" algoitem="AFFICHER &quot; Quel est le taux d'intérets correspondant (donner la valeur en %) ? &quot;"/>
        <item code="2#t#pasliste" algoitem="LIRE t"/>
        <item code="5#t#t/100#pasliste" algoitem="t PREND_LA_VALEUR t/100"/>
        <item code="5#n#0#pasliste" algoitem="n PREND_LA_VALEUR 0"/>
        <item code="5#Cn#c#pasliste" algoitem="Cn PREND_LA_VALEUR c"/>
        <item code="15#Cn &lt;= c*2" algoitem="TANT_QUE (Cn &lt;= c*2) FAIRE">
            <item code="16#debuttantque" algoitem="DEBUT_TANT_QUE"/>
            <item code="5#n#n + 1#pasliste" algoitem="n PREND_LA_VALEUR n + 1"/>
            <item code="5#Cn#Cn*(pow((1+t),n))#pasliste" algoitem="Cn PREND_LA_VALEUR Cn*(pow((1+t),n))"/>
            <item code="3#n#1#pasliste" algoitem="AFFICHER n"/>
            <item code="3#Cn#1#pasliste" algoitem="AFFICHER Cn"/>
            <item code="17#fintantque" algoitem="FIN_TANT_QUE"/>
        </item>
        <item code="5#reponse#&quot;En plaçant &quot; + c + &quot; euros, au taux de : &quot; + t + &quot; pendant &quot; + n + &quot; années, votre nouveau capital sera de : &quot; + round(Cn) + &quot; euros. Soit un bénéfice de : &quot; + round(Cn-c) + &quot; euros. &quot;#pasliste" algoitem="reponse PREND_LA_VALEUR &quot;En plaçant &quot; + c + &quot; euros, au taux de : &quot; + t + &quot; pendant &quot; + n + &quot; années, votre nouveau capital sera de : &quot; + round(Cn) + &quot; euros. Soit un bénéfice de : &quot; + round(Cn-c) + &quot; euros. &quot;"/>
        <item code="3#reponse#1#pasliste" algoitem="AFFICHER reponse"/>
    </item>
    <item code="102#finalgo" algoitem="FIN_ALGORITHME"/>
</Algo>
