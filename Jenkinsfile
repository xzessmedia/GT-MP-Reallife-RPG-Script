pipeline {
    agent none 
    stages {
		stage('Sonar-Scan') {		
			script {
				if (env.BRANCH_NAME != 'master') {
					if (env.BRANCH_NAME.startsWith('PR-')) {
						echo env.BRANCH_NAME
					} else {
						sh "ls"
						withSonarQubeEnv('TerraTex SonarQube') {
							sh "${tool 'SonarQubeScanner'}/bin/sonar-scanner -Dsonar.projectVersion=${BUILD_DISPLAY_NAME} -X"
						}
						timeout(time: 1, unit: 'HOURS') {
							def qg = waitForQualityGate()
							if (qg.status != 'OK') {
								error "Pipeline aborted due to quality gate failure: ${qg.status}"
							}
						}		
					}
				}			
			}		
		}
	}
}