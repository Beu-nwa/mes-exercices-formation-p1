<?xml version="1.0" encoding="UTF-8"?>
<Algo>
    <description courant="AFFICHER reponse" texte=""/>
    <extension extnom="inactif"/>
    <fonction fctetat="inactif" fctcode=""/>
    <F2 F2defaut="" F2para="" F2etat="inactif" F2lignes=""/>
    <repere repetat="inactif" repcode="-10#10#-10#10#2#2"/>
    <param epaisseurPoint="2" nbDecimales="8" epaisseurLigne="2" totalBoucles="5000000" totalAffichages="1000" arrondiAuto="vrai" maxBoucle="500000"/>
    <item code="200#declarationfonctions" algoitem="FONCTIONS_UTILISEES"/>
    <item code="100#declarationsvariables" algoitem="VARIABLES">
        <item code="1#NOMBRE#n" algoitem="n EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#cout" algoitem="cout EST_DU_TYPE NOMBRE"/>
        <item code="1#NOMBRE#prix" algoitem="prix EST_DU_TYPE NOMBRE"/>
        <item code="1#CHAINE#reponse" algoitem="reponse EST_DU_TYPE CHAINE"/>
    </item>
    <item code="101#debutalgo" algoitem="DEBUT_ALGORITHME">
        <item code="3#reponse#1#pasliste" algoitem="AFFICHER reponse"/>
        <item code="4#De combien de photocopies avez vous besoin ?#1" algoitem="AFFICHER &quot;De combien de photocopies avez vous besoin ?&quot;"/>
        <item code="2#n#pasliste" algoitem="LIRE n"/>
        <item code="6#n>0" algoitem="SI (n>0) ALORS">
            <item code="7#debutsi" algoitem="DEBUT_SI"/>
            <item code="6# n &lt; 10 " algoitem="SI ( n &lt; 10 ) ALORS">
                <item code="7#debutsi" algoitem="DEBUT_SI"/>
                <item code="5#cout#0.5#pasliste" algoitem="cout PREND_LA_VALEUR 0.5"/>
                <item code="8#finsi" algoitem="FIN_SI"/>
                <item code="9#sinon" algoitem="SINON">
                    <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                    <item code="6# n &lt;= 20 " algoitem="SI ( n &lt;= 20 ) ALORS">
                        <item code="7#debutsi" algoitem="DEBUT_SI"/>
                        <item code="5#cout#0.4#pasliste" algoitem="cout PREND_LA_VALEUR 0.4"/>
                        <item code="8#finsi" algoitem="FIN_SI"/>
                        <item code="9#sinon" algoitem="SINON">
                            <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                            <item code="5#cout#0.3#pasliste" algoitem="cout PREND_LA_VALEUR 0.3"/>
                            <item code="11#finsinon" algoitem="FIN_SINON"/>
                        </item>
                    </item>
                    <item code="11#finsinon" algoitem="FIN_SINON"/>
                </item>
            </item>
            <item code="5#prix#n * cout#pasliste" algoitem="prix PREND_LA_VALEUR n * cout"/>
            <item code="5#reponse#&quot; Vous avez demandé &quot; + n + &quot; photocopies, au cout de &quot; + cout + &quot; euros par exemplaire. Cela vous fera un total de : &quot; + prix + &quot; euros. &quot;#pasliste" algoitem="reponse PREND_LA_VALEUR &quot; Vous avez demandé &quot; + n + &quot; photocopies, au cout de &quot; + cout + &quot; euros par exemplaire. Cela vous fera un total de : &quot; + prix + &quot; euros. &quot;"/>
            <item code="8#finsi" algoitem="FIN_SI"/>
            <item code="9#sinon" algoitem="SINON">
                <item code="10#debutsinon" algoitem="DEBUT_SINON"/>
                <item code="5#reponse#&quot; valeur invalide ! &quot;#pasliste" algoitem="reponse PREND_LA_VALEUR &quot; valeur invalide ! &quot;"/>
                <item code="11#finsinon" algoitem="FIN_SINON"/>
            </item>
        </item>
        <item code="3#reponse#1#pasliste" algoitem="AFFICHER reponse"/>
    </item>
    <item code="102#finalgo" algoitem="FIN_ALGORITHME"/>
</Algo>
