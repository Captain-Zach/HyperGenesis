import React from 'react';
import { useEffect, useState } from "react";

const Main = () => {
    // main logic up herek
    const [map, setMap] = useState([]);
    useEffect(() => {
        console.log("Things happening");
    }, [map])
    async function GenerateMapola(){
        console.log("Generate mapola!");
        await fetch("https://localhost:5001/GenRoom")
            .then(async res => {
                console.log(res);
                res = await res.json();
                console.log(res.Map);
                setMap(res.Map);
            });
    }
    const changeUp = async (y, x) => {
        let check = map[y][x];
        if(check == 1){
            map[y][x] = 0;
        }else{
            map[y][x] = 1;
        }
        // await setMap(map);
        setMap([...map]);
        console.log(map);
        console.log("things are supposed to change");
    }
    
    return (
        <div>
            {/* Main body here */}
            <button onClick={GenerateMapola}>Generate Map</button>
            {map.map((row, y) => 
            <div>
                {row.map((block, x) => 
                    <button onClick={() => changeUp(y,x)}>{block}</button>
                )}
            </div>
                )}
        </div>
    )
}

export default Main;