import "./App.css";
import { useState, usestate } from "react";
import Axios from 'axios';

function App(){

  // for name state
  const [pokemonName, setPokemonName] = useState("");

  //just boolean to check whether pokemon is chosen or not
  const [pokemonChosen, setPokemonChosen] = useState(false);


  //to set all variables for display
  const [pokemon, setPokemon ] = useState({
        name: "", 
        species: "", 
        img: "", 
        hp: "",
        attack: "",
        defense: "",
        type: "",
  })

  //using then function to resolve the promise getting from api

  const searchPokemon = () => {
    Axios.get(`https://pokeapi.co/api/v2/pokemon/${pokemonName}`).then((response) => {
      setPokemon({
        name: pokemonName, 
        species: response.data.species.name, 
        img: response.data.sprites.front_default, 
        hp: response.data.stats[0].base_stat,
        attack: response.data.stats[1].base_stat,
        defense: response.data.stats[2].base_stat,
        type: response.data.types[0].type.name,

      });
      setPokemonChosen(true);
    }
    );

  }

 

  return(
    <div className = "App">
      <div className = "Title_class">
        <h1>Pokemon Stats</h1>

        <div><h1>Author : Shubham Mukherjee</h1></div>

        {/* to get value from searchbar and save it in pokemonName */}
        <input type = "text" id='text_id1' onChange={(event) => {setPokemonName(event.target.value)}}/>

        {/* using axios for api request */}
        <button onClick={searchPokemon}>Search Pokemon</button>
      </div>

      <div className="DisplaySection">{!pokemonChosen ? 
      (<h1>Please choose a pokemon</h1>) : 
      (
      
      <div className="Printing_class">     
      <h1>Pokemon Name : {pokemonName}</h1>
      <img src = {pokemon.img} />
      <h2>Species : {pokemon.species}</h2>
      <h2>Type : {pokemon.type}</h2>
      <h2>HP : {pokemon.hp}</h2>
      <h2>Attack: {pokemon.attack}</h2>
      <h2>Defense: {pokemon.defense}</h2>

      </div>
      )}
      </div>

    </div>

  );
}

export default App;