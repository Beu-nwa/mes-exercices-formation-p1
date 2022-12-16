import { Avion } from "./assets/avion";
import { Maison } from "./maison";
import { Voiture } from "./voiture";

const maisonVoitures = new Maison<Voiture>()

const maisonAvions = new Maison<Avion>()