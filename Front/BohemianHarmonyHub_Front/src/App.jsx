import { useState } from 'react'
import './App.css'
import Band from './Components/Band'

function App() {

  const bandas = [
    "Led Zeppelin",
    "The Beatles",
    "Queen",
    "Pink Floyd",
    "Nirvana",
    "Radiohead",
    "The Rolling Stones",
    "U2",
    "Metallica",
    "AC/DC"
  ]; 

  let bands = bandas.map(e => (<p>{e}</p>))

  return (
    <>
      <header className='header'>
        <h1 className='name'>Bohemian Harmony Hub</h1>
      </header>
      <main>
        <Band/>
          <div>
            {
              bandas.map(e => (
                <p>{e}</p>
              ))
            }
            {bands}
          </div>
      </main>
      <footer>

      </footer>


    </>
  )
}

export default App
