import { useState } from 'react';
import axios from 'axios';
import './BandModal.css'


function BandModal(){
    const [data, setData] = useState([])

    const url = "https://localhost:7117/Bands/details/2";
    const req = () =>
    axios.get(url).then((res) => {
      setData(res.data);
      return console.log(res.data);
    });

    return(
      
        <div className='index'>
            <button onClick={req}>click</button>
            {data.map((res) => (
                <p>{res.name}</p>
            ))}
            <div className="band-country">
            <p>PAISSSSSSSSSSSSSSSS</p>
            </div>
            <div className="band-name">
            <p>NOMENOMENOMENOMENOME</p>
            </div>
            <div className="band-genre">
            <p>GENEROGENEROGENERO</p>
            </div>
        <div className="band-bio">BIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBI
        OBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIO
        BIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBI
        OBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOB
        IOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIOBIO</div>
        </div>
     
    
    );
};

export default BandModal;

