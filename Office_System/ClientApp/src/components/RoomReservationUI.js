import React, { Component } from 'react';
import { useState } from 'react';
import ReactDatePicker from 'react-datepicker';

import "react-datepicker/dist/react-datepicker.css";
import 'bootstrap/dist/css/bootstrap.min.css';


export class RoomReservationUI extends Component {
    static displayName = RoomReservationUI.name;

    constructor(props) {
        super(props);
        this.state = {loading: true };
    }

    componentDidMount() {
        this.populateWeatherData();
    }

    static renderForecastsTable(forecasts) {
        return (
            <p>Zrobione!</p>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : RoomReservationUI.renderForecastsTable(this.state.forecasts);

        return (
            <div>
                <h1 id="tableLabel">Weather forecast</h1>
                <p>This component demonstrates fetching data from the server.</p>
                {contents}
            </div>
        );
    }

    
    async populateWeatherData() {
        var jsonData = {
            startDateTime: "2023-03-19T17:41:01.497Z",
            endDateTime: "2024-03-19T17:41:01.497Z",
            roomId: 1
        };
        const requestOptions = {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(jsonData)
        };
        const response = await fetch('https://localhost:44452/roomreservation', requestOptions);            ;
        this.setState({ loading: false });
    }
}