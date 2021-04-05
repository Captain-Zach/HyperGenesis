import React from 'react';
import { useEffect, useState } from "react";

const Main = () => {
    // main logic up here
    const [map, setMap] = useState([]);
    useEffect(() => {
        console.log("Things happening");
    }, [map])

    // GM is used to reach out to the 
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
        setMap([...map]); // easiest way to make this work, change map, then put the changed map into set map using ...map
        console.log(map); // ... is used to populate the list using a different list since these things aren't 1-1
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