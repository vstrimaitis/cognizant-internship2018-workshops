// @flow
import React, {Component} from "react";

import {Greeting} from "./components/Greeting";
import {BlinkingGreeting} from "./components/BlinkingGreeting";

export default class App extends Component<{}> {
    render () {
        return <BlinkingGreeting name="Bob" blinkPeriodMillis={500} />
    }
}