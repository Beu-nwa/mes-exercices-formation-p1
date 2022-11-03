<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="AFFICHER reponse" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2lignes="" F2etat="inactif" F2para="" F2defaut=""/>
    <repere repcode="-10#10#-10#10#2#2" repetat="inactif"/>
    <param maxBoucle="500000" nbDecimales="8" totalAffichages="1000" totalBoucles="5000000" epaisseurLigne="2" epaisseurPoint="2" arrondiAuto="vrai"/>
    <item algoitem="FONCTIONS_UTILISEES" code="200#declarationfonctions"/>
    <item algoitem="VARIABLES" code="100#declarationsvariables">
        <item algoitem="n EST_DU_TYPE NOMBRE" code="1#NOMBRE#n"/>
        <item algoitem="cout EST_DU_TYPE NOMBRE" code="1#NOMBRE#cout"/>
        <item algoitem="prix EST_DU_TYPE NOMBRE" code="1#NOMBRE#prix"/>
        <item algoitem="reponse EST_DU_TYPE CHAINE" code="1#CHAINE#reponse"/>
    </item>
    <item algoitem="DEBUT_ALGORITHME" code="101#debutalgo">
        <item algoitem="AFFICHER &quot; Combien de photocopies voulez vous ? &quot;" code="4# Combien de photocopies voulez vous ? #1"/>
        <item algoitem="LIRE n" code="2#n#pasliste"/>
        <item algoitem="SI (n &lt; 0) ALORS" code="6#n &lt; 0">
            <item algoitem="DEBUT_SI" code="7#debutsi"/>
            <item algoitem="n PREND_LA_VALEUR n * ( -1 )" code="5#n#n * ( -1 )#pasliste"/>
            <item algoitem="FIN_SI" code="8#finsi">
                <item algoitem="DEBUT_SI" code="7#debutsi"/>
                <item algoitem="SI ( n &lt; 10 ) ALORS" code="6# n &lt; 10 ">
                    <item algoitem="DEBUT_SI" code="7#debutsi"/>
                    <item algoitem="cout PREND_LA_VALEUR 0.5" code="5#cout#0.5#pasliste"/>
                    <item algoitem="FIN_SI" code="8#finsi"/>
                    <item algoitem="SINON" code="9#sinon">
                        <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                        <item algoitem="SI ( n &lt;= 20 ) ALORS" code="6# n &lt;= 20 ">
                            <item algoitem="DEBUT_SI" code="7#debutsi"/>
                            <item algoitem="cout PREND_LA_VALEUR 0.4" code="5#cout#0.4#pasliste"/>
                            <item algoitem="FIN_SI" code="8#finsi"/>
                            <item algoitem="SINON" code="9#sinon">
                                <item algoitem="DEBUT_SINON" code="10#debutsinon"/>
                                <item algoitem="cout PREND_LA_VALEUR 0.3" code="5#cout#0.3#pasliste"/>
                                <item algoitem="FIN_SINON" code="11#finsinon"/>
                            </item>
                        </item>
                        <item algoitem="FIN_SINON" code="11#finsinon"/>
                    </item>
                </item>
                <item algoitem="FIN_SI" code="8#finsi"/>
            </item>
        </item>
        <item algoitem="prix PREND_LA_VALEUR n * cout" code="5#prix#n * cout#pasliste"/>
        <item algoitem="reponse PREND_LA_VALEUR &quot; Vous avez demandé &quot; + n + &quot; photocopies, au cout de &quot; + cout + &quot; euros par exemplaire. Cela vous fera un total de : &quot; + prix + &quot; euros. &quot;" code="5#reponse#&quot; Vous avez demandé &quot; + n + &quot; photocopies, au cout de &quot; + cout + &quot; euros par exemplaire. Cela vous fera un total de : &quot; + prix + &quot; euros. &quot;#pasliste"/>
        <item algoitem="AFFICHER reponse" code="3#reponse#1#pasliste"/>
    </item>
    <item algoitem="FIN_ALGORITHME" code="102#finalgo"/>
</Algo>
