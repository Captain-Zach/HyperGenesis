import React from 'react';

const Main = () => {
    // main logic up here
    async function GenerateMapola(){
        console.log("Generate mapola!");
        await fetch("https://localhost:5001/GenRoom")
            .then(async res => {
                console.log(res);
                res = await res.json();
                console.log(res.Map);
            });
            
    }
    return (
        <div>
            {/* Main body here */}
            <button onClick={GenerateMapola}>Generate Map</button>
        </div>
    )
}

export default Main;