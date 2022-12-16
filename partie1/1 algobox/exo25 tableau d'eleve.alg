<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description texte="" courant="FIN_POUR"/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2etat="inactif" F2lignes="" F2para="" F2defaut=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param nbDecimales="8" arrondiAuto="vrai" epaisseurLigne="2" maxBoucle="500000" totalBoucles="5000000" epaisseurPoint="2" totalAffichages="1000"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="i EST_DU_TYPE NOMBRE" code="1#NOMBRE#i"/>
        <item algoitem="j EST_DU_TYPE NOMBRE" code="1#NOMBRE#j"/>
        <item algoitem="k EST_DU_TYPE NOMBRE" code="1#NOMBRE#k"/>
        <item algoitem="n EST_DU_TYPE NOMBRE" code="1#NOMBRE#n"/>
        <item algoitem="m EST_DU_TYPE NOMBRE" code="1#NOMBRE#m"/>
        <item algoitem="ligne EST_DU_TYPE CHAINE" code="1#CHAINE#ligne"/>
        <item algoitem="th EST_DU_TYPE CHAINE" code="1#CHAINE#th"/>
        <item algoitem="tab EST_DU_TYPE LISTE" code="1#LISTE#tab"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="AFFICHER &quot; Définir le nombre de matiere n puis le nombre d'eleve m&quot;" code="4# Définir le nombre de matiere n puis le nombre d'eleve m#1"/>
        <item algoitem="LIRE n" code="2#n#pasliste"/>
        <item algoitem="LIRE m" code="2#m#pasliste"/>
        <item algoitem="th PREND_LA_VALEUR &quot;Matiere n°    &quot;" code="5#th#&quot;Matiere n°    &quot;#pasliste"/>
        <item algoitem="POUR i ALLANT_DE 0 A (n-1)" code="12#i#0#(n-1)">
            <item algoitem="DEBUT_POUR" code="13#debutpour"/>
            <item algoitem="th PREND_LA_VALEUR th + &quot; | &quot; + (i+1)" code="5#th#th + &quot; | &quot; + (i+1)#pasliste"/>
            <item algoitem="FIN_POUR" code="14#finpour"/>
        </item>
        <item algoitem="AFFICHER th" code="3#th#1#pasliste"/>
        <item algoitem="POUR k ALLANT_DE 0 A (m-1)" code="12#k#0#(m-1)">
            <item algoitem="DEBUT_POUR" code="13#debutpour"/>
            <item algoitem="ligne PREND_LA_VALEUR &quot;Etudiant n°:&quot; + (k+1)" code="5#ligne#&quot;Etudiant n°:&quot; + (k+1)#pasliste"/>
            <item algoitem="SI (k&lt;9) ALORS" code="6#k&lt;9">
                <item algoitem="DEBUT_SI" code="7#debutsi"/>
                <item algoitem="ligne PREND_LA_VALEUR ligne + &quot; &quot;" code="5#ligne#ligne + &quot; &quot;#pasliste"/>
                <item algoitem="FIN_SI" code="8#finsi"/>
            </item>
            <item algoitem="POUR j ALLANT_DE 0 A (n-1)" code="12#j#0#(n-1)">
                <item algoitem="DEBUT_POUR" code="13#debutpour"/>
                <item algoitem="tab[i+j] PREND_LA_VALEUR floor(10*random())" code="5#tab#floor(10*random())#i+j"/>
                <item algoitem="ligne PREND_LA_VALEUR ligne + &quot; | &quot; + tab[i+j]" code="5#ligne#ligne + &quot; | &quot; + tab[i+j]#pasliste"/>
                <item algoitem="FIN_POUR" code="14#finpour"/>
            </item>
            <item algoitem="AFFICHER ligne" code="3#ligne#1#pasliste"/>
            <item algoitem="FIN_POUR" code="14#finpour"/>
        </item>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
