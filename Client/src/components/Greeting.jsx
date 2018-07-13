// @flow
import React from "react";

type GreetingProps = {
    name: string
}

export const Greeting = (props: GreetingProps) => (
    <p>Hello {props.name}!</p>
);
