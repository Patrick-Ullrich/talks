import React, { useEffect, useState } from 'react';

export const Home = () => {
  const [sessions, setSessions] = useState([]);
  const [isLoading, setLoading] = useState(true)

  const loadData = async () => {
    setLoading(true)
    const response = await fetch('/api/sessions/getAll');
    const data = await response.json();
    setSessions(data);
    setLoading(false)
  }

  const signUpSession = async (sessionId) => {
    const response = await fetch('/api/sessions/signUpSession', {
      method: 'post',
      headers: {
        'Accept': 'application/json',
        'Content-Type': 'application/json'
      },
      body: JSON.stringify({
        sessionId
      })
    })
    const data = await response.json();
    setSessions(sessions.map(x => {
      if (x.sessionId === sessionId) {
        x.signUps = data;
      }
      return x;
    }))
  }

  const leaveSession = async (sessionId) => {
    const response = await fetch('/api/sessions/leaveSession', {
      method: 'post',
      headers: {
        'Accept': 'application/json',
        'Content-Type': 'application/json'
      },
      body: JSON.stringify({
        sessionId
      })
    })
    const data = await response.json();
    setSessions(sessions.map(x => {
      if (x.sessionId === sessionId) {
        x.signUps = data;
      }
      return x;
    }))
  }

  useEffect(() => {
    loadData();
  }, [])

  return (
    <div className="container-fluid">
      <h1>
        Sessions
      </h1>
      {
        isLoading ?
          <span>Loading...</span> :
          sessions.map((x, index) => (
            <div key={index} className="row mb-3">
              <div className="col-12">
                <div className="card">
                  <div className="card-body">
                    <h2 className="card-title d-flex justify-content-between align-items-start">
                      {x.title}
                      <div className="d-flex align-items-center">
                        <button
                          onClick={() => leaveSession(x.sessionId)}
                          className="btn btn-danger btn-sm">
                          -
                        </button>
                        <span className="mx-2">
                          {x.signUps}
                        </span>
                        <button
                          onClick={() => signUpSession(x.sessionId)}
                          className="btn btn-primary btn-sm">
                          +
                      </button>
                      </div>

                    </h2>
                    <h4 className="card-title">
                      {x.speaker.name}
                    </h4>
                    <p className="card-text">
                      {x.description}
                    </p>
                  </div>
                </div>
              </div>
            </div>
          ))
      }
    </div>
  )
}