# Instructions

When generating XML documentation for methods, you should include a description of each parameter and an example of a valid input.

When generating a README file, use the following template:
### README Template
1. **Project Title**
    - Extract from the project name or display "To be filled later".
2. **Description**
    - Use any available project description (e.g., from metadata, comments, or file summaries). Otherwise, add:  
`"Description: To be filled later."`
3. **Installation**
    - List dependencies and setup instructions found in the project (e.g., `package.json`, `requirements.txt`).
    - Use `"Installation steps: To be filled later"` if no setup is defined.
4. **Usage**
    - Include examples from test cases or sample files, or add:  
`"Usage details: To be filled later."`
5. **Debugging Instructions**
    - Extract information about logs or debugging tools from code (e.g., logging libraries or debug settings).
    - Add: `"Debugging instructions: To be filled later."` if undefined.
6. **Infrastructure and Deployment**
    - If deployment files (e.g., `Dockerfile`, `azure-pipelines.yml`) exist, summarize deployment steps.
    - Otherwise, write: `"Infrastructure and deployment information: To be filled later."`
7. **Results and Data Access**
    - Describe accessible output files, APIs, or logs.
    - Write: `"Results and data access: To be filled later."` if no details are found.
8. **API Documentation**
    - Generate endpoint details if code includes API annotations (e.g., Swagger, XML docs).
    - Use: `"API documentation: To be filled later."` if APIs are not detected.
9. **Contributing**
    - Add instructions for contributing based on existing `CONTRIBUTING.md`.
    - Write: `"Contributing information: To be filled later."` if no guidelines exist.
10. **License**
    - Extract license details or add: `"License: To be filled later."`