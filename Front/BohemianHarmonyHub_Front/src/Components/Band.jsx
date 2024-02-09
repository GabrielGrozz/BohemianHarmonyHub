import { useState } from "react";

function Band(){
    [data, setData] = useState(0)
    return(
        <>
        <button onClick={() => setData(data += 1)}> clique</button>
        <h3>{data}</h3>
        </>
    )
}

export default Band;