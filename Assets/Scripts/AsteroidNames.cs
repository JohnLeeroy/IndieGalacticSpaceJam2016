using UnityEngine;
using System.Collections;

public class AsteroidNames {

	private static AsteroidNames instance = new AsteroidNames();
	public static AsteroidNames Instance {
		get { return instance; }
	}

	public string[] names = {"Ceres 1",
		"Pallas 2",
		"Vesta 4",
		"Hygiea 10",
		"Sylvia 87",
		"Hektor 624",
		"Europa 52",
		"Eunomia 15",
		"Davida 511",
		"Interamnia 704",
		"Camilla 107",
		"Juno 3",
		"Cybele 65",
		"Hermione 121",
		"Euphrosyne 31",
		"Chariklo 10199",
		"Iris 7",
		"Psyche 16",
		"Daphne 41",
		"Kalliope 22",
		"Amphitrite 29",
		"Eugenia 45",
		"Bamberga 324",
		"Patientia 451",
		"Fortuna 19",
		"Aurora 94",
		"Herculina 532",
		"Metis 9",
		"Doris 48",
		"Elektra 130",
		"Diotima 423",
		"Egeria 13",
		"Hebe 6",
		"Themis 24",
		"Alauda 702",
		"Palma 372",
		"Nemesis 128",
		"Bertha 154",
		"Freia 76",
		"Aletheia 259"
	};

	int index = 0;

	public string getNextAsteroidName() {
		string name = names [index];
		index++;
		return name;
	}
}
