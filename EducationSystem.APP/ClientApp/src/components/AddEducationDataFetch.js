import React, { Component } from 'react';

export class AddEducationDataFetch extends Component {
    static displayName = AddEducationDataFetch.name;

    constructor(props) {
        super(props);
        this.state = {};
    }

    componentDidMount() { }


    render() {

        const handleSubmit = (event) => {
            // Prevent page reload
            event.preventDefault();

            fetch('education/add-education', {
                headers: {
                    'Accept': 'application/json, text/plain',
                    'Content-Type': 'application/json;charset=UTF-8'
                },
                method: 'POST',
                body: JSON.stringify({
                    name: this.state.name,
                    startDate: this.state.startDate,
                    endDate: this.state.endDate
                }),
            })
                .then((response) => response.json())
                .then((data) => {
                    // Check data
                    if (data.responseCode == 0)
                        window.location.href = "/get-educations";
                })
        };
        return (
            <div className="Auth-form-container">
                <form className="Auth-form" onSubmit={handleSubmit}>
                    <div className="Auth-form-content">
                        <div className="form-group mt-3">
                            <label>Name</label>
                            <input required
                                name="name"
                                className="form-control mt-1"
                                placeholder="Name"
                                onChange={e => this.state.name = e.target.value}

                            />
                        </div>
                        <div className="form-group mt-3">
                            <label>Start Date</label>
                            <input required
                                type="date"
                                className="form-control mt-1"
                                onChange={e => this.state.startDate = e.target.value}
                            />
                        </div>
                        <div className="form-group mt-3">
                            <label>End Date</label>
                            <input required
                                type="date"
                                className="form-control mt-1"
                                onChange={e => this.state.endDate = e.target.value}
                            />
                        </div>
                        <div className="d-grid gap-2 mt-3">
                            <button type="submit" className="btn btn-primary">
                                Submit
                            </button>
                        </div>
                    </div>
                </form>
            </div>


        );
    }

}
