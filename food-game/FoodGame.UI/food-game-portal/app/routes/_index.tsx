import React from "react";
import {FoodApi} from "~/generated/client";
import {json} from "@remix-run/node";
import {useLoaderData} from "@remix-run/react";

export async function loader() {
    const foodApi = new FoodApi();

    return json({
        foods: await foodApi.getFoods()
    })
}

export default function Index() {

    const data = useLoaderData<typeof loader>();

    return (
        <div style={{fontFamily: "system-ui, sans-serif", lineHeight: "1.8"}}>
            <h1>Welcome to Remix</h1>
            <ul>
                {
                    data.foods.map(food => (
                        <li>{food.name}</li>
                    ))
                }
            </ul>
        </div>
    );
}
