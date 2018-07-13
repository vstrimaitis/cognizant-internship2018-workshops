// @flow
import React, {Component} from "react";

type BlinkingGreetingProps = {
    name: string,
    blinkPeriodMillis: number
}

type BlinkingGreetingState = {
    isVisible: boolean
}

export class BlinkingGreeting extends Component<BlinkingGreetingProps, BlinkingGreetingState> {
    state: BlinkingGreetingState = {
        isVisible: true
    }
    componentDidMount () {
        setInterval(() => {
            this.setState({isVisible: !this.state.isVisible});
        },this.props.blinkPeriodMillis);
    }
    render () {
        const underline = {
            fontWeight: this.state.isVisible ? "bold" : "normal"
        };
        return (
            <p>Hello <span style={underline}>{this.props.name}</span>!</p>
        );
    }
}
