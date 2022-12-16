<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description texte="" courant="AFFICHER reponse"/>
    <extension extnom="inactif"/>
    <fonction fctcode="" fctetat="inactif"/>
    <F2 F2lignes="" F2etat="inactif" F2para="" F2defaut=""/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param arrondiAuto="vrai" epaisseurPoint="2" maxBoucle="500000" totalBoucles="5000000" epaisseurLigne="2" totalAffichages="1000" nbDecimales="8"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="c EST_DU_TYPE NOMBRE" code="1#NOMBRE#c"/>
        <item algoitem="t EST_DU_TYPE NOMBRE" code="1#NOMBRE#t"/>
        <item algoitem="n EST_DU_TYPE NOMBRE" code="1#NOMBRE#n"/>
        <item algoitem="Cn EST_DU_TYPE NOMBRE" code="1#NOMBRE#Cn"/>
        <item algoitem="b EST_DU_TYPE NOMBRE" code="1#NOMBRE#b"/>
        <item algoitem="reponse EST_DU_TYPE CHAINE" code="1#CHAINE#reponse"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="AFFICHER &quot; Quel est le montant du capital que vous voulez placer ? &quot;" code="4# Quel est le montant du capital que vous voulez placer ? #1"/>
        <item algoitem="LIRE c" code="2#c#pasliste"/>
        <item algoitem="AFFICHER &quot; Quel est le taux d'intérets correspondant (donner la valeur en %) ? &quot;" code="4# Quel est le taux d'intérets correspondant (donner la valeur en %) ? #1"/>
        <item algoitem="LIRE t" code="2#t#pasliste"/>
        <item algoitem="t PREND_LA_VALEUR t/100" code="5#t#t/100#pasliste"/>
        <item algoitem="AFFICHER &quot; Pendant combien d'année voulez vous placer votre argent ? &quot;" code="4# Pendant combien d'année voulez vous placer votre argent ? #1"/>
        <item algoitem="LIRE n" code="2#n#pasliste"/>
        <item algoitem="Cn PREND_LA_VALEUR round(c*(pow((1+t),n)))" code="5#Cn#round(c*(pow((1+t),n)))#pasliste"/>
        <item algoitem="b PREND_LA_VALEUR Cn - c" code="5#b#Cn - c#pasliste"/>
        <item algoitem="reponse PREND_LA_VALEUR &quot;En plaçant &quot; + c + &quot; euros, au taux de : &quot; + t + &quot; pendant &quot; + n + &quot; années, votre nouveau capital sera de : &quot; + Cn + &quot; euros. Soit un bénéfice de : &quot; + b + &quot; euros. &quot;" code="5#reponse#&quot;En plaçant &quot; + c + &quot; euros, au taux de : &quot; + t + &quot; pendant &quot; + n + &quot; années, votre nouveau capital sera de : &quot; + Cn + &quot; euros. Soit un bénéfice de : &quot; + b + &quot; euros. &quot;#pasliste"/>
        <item algoitem="AFFICHER reponse" code="3#reponse#1#pasliste"/>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
