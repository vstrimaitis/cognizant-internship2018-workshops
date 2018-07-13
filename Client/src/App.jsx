// @flow
import React, {Component} from "react";

import {Greeting} from "./components/Greeting";
import {BlinkingGreeting} from "./components/BlinkingGreeting";
import {config} from "./config/config";

export default class App extends Component<{}> {
    render () {
        console.info(config);
        return <BlinkingGreeting name="Bob" blinkPeriodMillis={500} />
    }
}